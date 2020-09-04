using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPDRSystem.Models;
using WebPDRSystem.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using RequestSizeLimitAttribute = WebPDRSystem.Helpers.RequestSizeLimitAttribute;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebPDRSystem.Models.ViewModels;

namespace WebPDRSystem.Controllers
{
    [Authorize(Policy = "resuhems")]
    public class ResuhemsController : Controller
    {

        private const uint V = 2147483648;
        private readonly WebPDRContext _context;

        public ResuhemsController(WebPDRContext context)
        {
            _context = context;
        }

        public static List<KeyValuePair<string, string>> BloodTypes
        {
            get
            {
                return new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("O+","O+"),
                    new KeyValuePair<string, string>("O-","O-"),
                    new KeyValuePair<string, string>("A+","A+"),
                    new KeyValuePair<string, string>("A-","A-"),
                    new KeyValuePair<string, string>("B+","B+"),
                    new KeyValuePair<string, string>("B-","B-"),
                    new KeyValuePair<string, string>("AB+","AB+"),
                    new KeyValuePair<string, string>("AB-","AB-"),
                };
            }
        }

        public static List<KeyValuePair<string, string>> CivilStatus
        {
            get
            {
                return new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("single","Single"),
                    new KeyValuePair<string, string>("married","Married"),
                    new KeyValuePair<string, string>("divorced","Divorced"),
                    new KeyValuePair<string, string>("separated","Separated"),
                    new KeyValuePair<string, string>("widowed","Widowed")
                };
            }
        }

        #region INDEXES
        [HttpGet]
        [Route("Resuhems/PatientsJson")]
        [Route("Resuhems/PatientsJson/{q}")]
        public async Task<ActionResult<IEnumerable<ResuPatientsModel>>> PatientsJson(string q)
        {
            var pdrs = await _context.Pdr
                .Include(z => z.PatientNavigation).ThenInclude(z => z.BarangayNavigation)
                .Include(z => z.PatientNavigation).ThenInclude(z => z.MuncityNavigation)
                .Include(y => y.PatientNavigation).ThenInclude(y => y.ProvinceNavigation)
                .Include(x=>x.GuardianNavigation)
                .Where(x=>x.QuarantineFacility == UserFacility)
                .Select(x=> new ResuPatientsModel
                {
                    Name = x.PatientNavigation.GetFullName(),
                    Age = x.PatientNavigation.DateOfBirth.ComputeAge(),
                    Sex = x.PatientNavigation.Gender? "Male" : "Female",
                    DoB = x.PatientNavigation.DateOfBirth,
                    Address = x.PatientNavigation.GetAddress(),
                    Guardian = x.GuardianNavigation.GetFullName(),
                    DateAdmitted = x.DateOfAdmission,
                    GuardianContactNo = x.GuardianNavigation.ContactNumber,
                    PatientContactNo = x.PatientNavigation.ContactNumber
                })
                .OrderByDescending(x => x.DateAdmitted)
                .ToListAsync();

            if (!string.IsNullOrEmpty(q))
            {
                pdrs = pdrs.Where(x => x.Name.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return pdrs;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DashboardPartial([FromBody] IEnumerable<ResuPatientsModel> model)
        {
            return PartialView(model);
        }
        #endregion
        #region ADD PATIENT

        public IActionResult AddPatient()
        {
            ViewBag.CivilStatus = new SelectList(CivilStatus, "Key", "Value");
            ViewBag.BloodTypes = new SelectList(BloodTypes, "Key", "Value");
            ViewBag.Users = new SelectList(GetDocNurse(), "Id", "Fullname");
            ViewBag.ProvincesP = new SelectList(_context.Province, "Id", "Description", 2);
            ViewBag.MuncityP = new SelectList(_context.Muncity.Where(x => x.ProvinceId == 2), "Id", "Description");
            ViewBag.ProvincesG = new SelectList(_context.Province, "Id", "Description", 2);
            ViewBag.MuncityG = new SelectList(_context.Muncity.Where(x => x.ProvinceId == 2), "Id", "Description");
            return View(new Pdr
            {
                DateOfAdmission = DateTime.Now.RemoveSeconds()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(valueCountLimit: 1073741824)]
        public async Task<IActionResult> AddPatient(Pdr model)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            model.Status = "admitted";
            model.CreatedAt = DateTime.Now;
            model.UpdatedAt = DateTime.Now;
            model.PatientNavigation.CreatedAt = DateTime.Now;
            model.PatientNavigation.UpdatedAt = DateTime.Now;
            model.GuardianNavigation.CreatedAt = DateTime.Now;
            model.GuardianNavigation.UpdatedAt = DateTime.Now;
            model.Pdrcode = model.PatientNavigation.Lastname + model.PatientNavigation.Middlename + model.PatientNavigation.Firstname + model.CreatedAt.ToString("ddMMyyyyHHmm");
            model.GuardianNavigation.Address = "";
            model.SymptomsContacts.CloseContacts = model.SymptomsContacts.CloseContacts ?? "none";
            model.SymptomsContacts.SymptomsOfPatient = model.SymptomsContacts.SymptomsOfPatient ?? "none";
            //model.PatientNavigation.Picture = SavePicture(model.PatientNavigation.Firstname + model.PatientNavigation.Lastname, model.PatientNavigation.Picture);
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Dashboard));
            }
            ViewBag.ProvincesP = new SelectList(_context.Province, "Id", "Description", model.PatientNavigation.Province);
            ViewBag.MuncityP = new SelectList(_context.Muncity.Where(x => x.ProvinceId == 2), "Id", "Description", model.PatientNavigation.Muncity);
            ViewBag.ProvincesG = new SelectList(_context.Province, "Id", "Description", model.GuardianNavigation.Province);
            ViewBag.MuncityG = new SelectList(_context.Muncity.Where(x => x.ProvinceId == 2), "Id", "Description", model.GuardianNavigation.Muncity);
            if (model.PatientNavigation.Barangay != null)
            {
                ViewBag.BarangayP = new SelectList(_context.Barangay.Where(x => x.ProvinceId == model.PatientNavigation.Province && x.MuncityId == model.PatientNavigation.Muncity), "Id", "Description", model.PatientNavigation.Barangay);
            }

            if (model.GuardianNavigation.Barangay != null)
            {
                ViewBag.BarangayG = new SelectList(_context.Barangay.Where(x => x.ProvinceId == model.GuardianNavigation.Province && x.MuncityId == model.GuardianNavigation.Muncity), "Id", "Description", model.GuardianNavigation.Barangay);
            }
            ViewBag.CivilStatus = new SelectList(CivilStatus, "Key", "Value");
            ViewBag.BloodTypes = new SelectList(BloodTypes, "Key", "Value");
            ViewBag.Errors = errors;
            return View(model);
        }

        #endregion
        #region DISCHARGE
        public async Task<IActionResult> DischargedPatients(string search)
        {
            var patients = await _context.Pdr
                .Include(x => x.PatientNavigation).ThenInclude(x => x.BarangayNavigation)
                .Include(x => x.PatientNavigation).ThenInclude(x => x.MuncityNavigation)
                .Include(x => x.PatientNavigation).ThenInclude(x => x.ProvinceNavigation)
                .Where(x => x.QuarantineFacility == UserFacility)
                .Where(x => x.Status == "discharged")
                .OrderByDescending(x => x.UpdatedAt)
                .ToListAsync();

            return View(patients);
        }
        #endregion


        #region HELPERS

        public partial class SelectUsers
        {
            public int Id { get; set; }
            public string Fullname { get; set; }
        }
        public List<SelectUsers> GetDoctors()
        {
            var users = _context.Pdrusers
                .Where(x => x.Team == 1 && x.Role == "Doctor")
                .Select(x => new SelectUsers
                {
                    Id = x.Id,
                    Fullname = x.Firstname + " " + x.Lastname
                });

            return users.ToList();
        }

        public List<SelectUsers> Gethcb()
        {
            var users = _context.Pdrusers
                .Where(x => x.Team == 1 && x.Role == "Healthcare Buddy")
                .Select(x => new SelectUsers
                {
                    Id = x.Id,
                    Fullname = x.Firstname + " " + x.Lastname
                });

            return users.ToList();
        }
        public List<SelectUsers> GetDocNurse()
        {
            var users = _context.Pdrusers
                .Where(x => x.Team == 1 && x.Role != "Healthcare Buddy")
                .Select(x => new SelectUsers
                {
                    Id = x.Id,
                    Fullname = x.Role == "Doctor" ? "Dr. " + x.Firstname + " " + x.Lastname : x.Firstname + " " + x.Lastname
                });

            return users.ToList();
        }
        public string UserFacility => User.FindFirstValue("Facility");
        #endregion
    }
}