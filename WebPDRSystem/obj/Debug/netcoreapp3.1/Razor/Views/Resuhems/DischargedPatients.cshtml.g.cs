#pragma checksum "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cfd2d016f17fadaa979b8126b87f731752659e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resuhems_DischargedPatients), @"mvc.1.0.view", @"/Views/Resuhems/DischargedPatients.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfd2d016f17fadaa979b8126b87f731752659e2", @"/Views/Resuhems/DischargedPatients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5a22c6d35617c1e3ce08ff0048f0e904e4c32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Resuhems_DischargedPatients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pdr>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
  
    ViewData["Title"] = "Discharged";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"" style=""margin-top: 20px;"">
    <div class=""card-header"">
        Discharged Patients
    </div>
    <div class=""card-body"">
        <table class=""table table-striped"" style=""vertical-align: middle; font-size: 15px;"">
            <thead class=""bg-gray-dark"">
                <tr>
                    <th class=""text-center"">
                        Name
                    </th>
                    <th class=""text-center"">
                        Sex
                    </th>
                    <th class=""text-center"">
                        Age/Date of Birth
                    </th>
                    <th class=""text-center"">
                        Address
                    </th>
                    <th>
                        Date of Admission
                    </th>
                    <th class=""text-center"">
                        Date Discharged
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                 foreach (var patient in Model)
                {
                    var gender = patient.PatientNavigation.Gender ? "Male" : "Female";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(patient.PatientNavigation.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(patient.PatientNavigation.DateOfBirth.ComputeAge());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <small>");
#nullable restore
#line 47 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                              Write(patient.PatientNavigation.DateOfBirth.GetDate("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(patient.PatientNavigation.GetAddress());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 53 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(patient.DateOfAdmission.GetDate("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 56 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                       Write(patient.UpdatedAt.GetDate("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Resuhems\DischargedPatients.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pdr>> Html { get; private set; }
    }
}
#pragma warning restore 1591