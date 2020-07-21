using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebPDRSystem.Models
{
    public partial class PDRDBContext : DbContext
    {
        public PDRDBContext()
        {
        }

        public PDRDBContext(DbContextOptions<PDRDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barangay> Barangay { get; set; }
        public virtual DbSet<Census> Census { get; set; }
        public virtual DbSet<Discharge> Discharge { get; set; }
        public virtual DbSet<DoctorOrders> DoctorOrders { get; set; }
        public virtual DbSet<Guardian> Guardian { get; set; }
        public virtual DbSet<LabResult> LabResult { get; set; }
        public virtual DbSet<ListDocOrders> ListDocOrders { get; set; }
        public virtual DbSet<Medications> Medications { get; set; }
        public virtual DbSet<Muncity> Muncity { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Pdr> Pdr { get; set; }
        public virtual DbSet<Pdrusers> Pdrusers { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Qdform> Qdform { get; set; }
        public virtual DbSet<Qnform> Qnform { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<SymptomsContacts> SymptomsContacts { get; set; }
        public virtual DbSet<TeamSchedule> TeamSchedule { get; set; }
        public virtual DbSet<Unusualities> Unusualities { get; set; }
        public virtual DbSet<UserTeams> UserTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-T0HC4BP;Initial Catalog=PDRDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barangay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Census>(entity =>
            {
                entity.HasIndex(e => e.Noda);

                entity.HasIndex(e => e.Nodb);

                entity.HasIndex(e => e.Odg);

                entity.HasIndex(e => e.Odr);

                entity.HasIndex(e => e.Qd);

                entity.Property(e => e.Noda).HasColumnName("NODA");

                entity.Property(e => e.Nodb).HasColumnName("NODB");

                entity.Property(e => e.Odg).HasColumnName("ODG");

                entity.Property(e => e.Odr).HasColumnName("ODR");

                entity.Property(e => e.Qd).HasColumnName("QD");

                entity.HasOne(d => d.NodaNavigation)
                    .WithMany(p => p.CensusNodaNavigation)
                    .HasForeignKey(d => d.Noda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NODA");

                entity.HasOne(d => d.NodbNavigation)
                    .WithMany(p => p.CensusNodbNavigation)
                    .HasForeignKey(d => d.Nodb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NODB");

                entity.HasOne(d => d.OdgNavigation)
                    .WithMany(p => p.CensusOdgNavigation)
                    .HasForeignKey(d => d.Odg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ODG");

                entity.HasOne(d => d.OdrNavigation)
                    .WithMany(p => p.CensusOdrNavigation)
                    .HasForeignKey(d => d.Odr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ODR");

                entity.HasOne(d => d.QdNavigation)
                    .WithMany(p => p.CensusQdNavigation)
                    .HasForeignKey(d => d.Qd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QD");
            });

            modelBuilder.Entity<Discharge>(entity =>
            {
                entity.HasIndex(e => e.DischargedBy);

                entity.HasIndex(e => e.HealthCareBuddy);

                entity.HasIndex(e => e.Pdrid);

                entity.Property(e => e.DischargedApprovedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GuardOnDuty)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pdrid).HasColumnName("PDRId");

                entity.Property(e => e.QuarantineDirectorOrOfficer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.DischargedByNavigation)
                    .WithMany(p => p.DischargeDischargedByNavigation)
                    .HasForeignKey(d => d.DischargedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DischargeBy");

                entity.HasOne(d => d.HealthCareBuddyNavigation)
                    .WithMany(p => p.DischargeHealthCareBuddyNavigation)
                    .HasForeignKey(d => d.HealthCareBuddy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DischargeTable_PDRUsers");

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.Discharge)
                    .HasForeignKey(d => d.Pdrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DischargeTable_PDRTable");
            });

            modelBuilder.Entity<DoctorOrders>(entity =>
            {
                entity.HasIndex(e => e.PdrId);

                entity.HasIndex(e => e.Signature);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.DoctorOrders)
                    .HasForeignKey(d => d.PdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorOrders_PDR");

                entity.HasOne(d => d.SignatureNavigation)
                    .WithMany(p => p.DoctorOrders)
                    .HasForeignKey(d => d.Signature)
                    .HasConstraintName("FK_DoctorOrders_PDRUsers1");
            });

            modelBuilder.Entity<Guardian>(entity =>
            {
                entity.HasIndex(e => e.Barangay);

                entity.HasIndex(e => e.Muncity);

                entity.HasIndex(e => e.Province);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.BarangayNavigation)
                    .WithMany(p => p.Guardian)
                    .HasForeignKey(d => d.Barangay)
                    .HasConstraintName("FK_Guardian_Barangay");

                entity.HasOne(d => d.MuncityNavigation)
                    .WithMany(p => p.Guardian)
                    .HasForeignKey(d => d.Muncity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Guardian_Muncity");

                entity.HasOne(d => d.ProvinceNavigation)
                    .WithMany(p => p.Guardian)
                    .HasForeignKey(d => d.Province)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Guardian_Province");
            });

            modelBuilder.Entity<LabResult>(entity =>
            {
                entity.HasIndex(e => e.AttendingPhysician);

                entity.HasIndex(e => e.PdrId);

                entity.Property(e => e.ResultPic)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.AttendingPhysicianNavigation)
                    .WithMany(p => p.LabResult)
                    .HasForeignKey(d => d.AttendingPhysician)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabResult_PDRUsers");

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.LabResult)
                    .HasForeignKey(d => d.PdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabResult_PDR");
            });

            modelBuilder.Entity<ListDocOrders>(entity =>
            {
                entity.HasIndex(e => e.DoctorOrderId);

                entity.Property(e => e.DoctorsOrder)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.DoctorOrder)
                    .WithMany(p => p.ListDocOrders)
                    .HasForeignKey(d => d.DoctorOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListDocOrders_DoctorOrders");
            });

            modelBuilder.Entity<Medications>(entity =>
            {
                entity.HasIndex(e => e.PatientId);

                entity.HasIndex(e => e.SignatureNurse);

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medications_Patient");

                entity.HasOne(d => d.SignatureNurseNavigation)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.SignatureNurse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medications_PDRUsers");
            });

            modelBuilder.Entity<Muncity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasIndex(e => e.Barangay);

                entity.HasIndex(e => e.Muncity);

                entity.HasIndex(e => e.Province);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CivilStatus)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BarangayNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Barangay)
                    .HasConstraintName("FK_Patient_Barangay");

                entity.HasOne(d => d.MuncityNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Muncity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Muncity");

                entity.HasOne(d => d.ProvinceNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Province)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Province");
            });

            modelBuilder.Entity<Pdr>(entity =>
            {
                entity.ToTable("PDR");

                entity.HasIndex(e => e.Guardian);

                entity.HasIndex(e => e.InterviewedBy);

                entity.HasIndex(e => e.Patient);

                entity.HasIndex(e => e.SymptomsContactsId);

                entity.Property(e => e.BedNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pdrcode)
                    .HasColumnName("PDRCode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.GuardianNavigation)
                    .WithMany(p => p.Pdr)
                    .HasForeignKey(d => d.Guardian)
                    .HasConstraintName("FK_PDRTable_Guardian");

                entity.HasOne(d => d.InterviewedByNavigation)
                    .WithMany(p => p.Pdr)
                    .HasForeignKey(d => d.InterviewedBy)
                    .HasConstraintName("FK_PDR_PDRUsers");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.Pdr)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK_PDR_Patient");

                entity.HasOne(d => d.SymptomsContacts)
                    .WithMany(p => p.Pdr)
                    .HasForeignKey(d => d.SymptomsContactsId)
                    .HasConstraintName("FK_PDR_SymptomsContacts");
            });

            modelBuilder.Entity<Pdrusers>(entity =>
            {
                entity.ToTable("PDRUsers");

                entity.HasIndex(e => e.Team);

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Facility)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Schedule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.TeamNavigation)
                    .WithMany(p => p.Pdrusers)
                    .HasForeignKey(d => d.Team)
                    .HasConstraintName("FK_PDRUsers_UserTeams");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PhotoFilePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoString)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qdform>(entity =>
            {
                entity.ToTable("QDForm");

                entity.HasIndex(e => e.HealthCareBuddy);

                entity.HasIndex(e => e.PdrId);

                entity.HasIndex(e => e.SignatureOfQd);

                entity.Property(e => e.HealthCareBuddy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtherDetails).HasColumnType("text");

                entity.Property(e => e.Pdrcode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureOfQd).HasColumnName("SignatureOfQD");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.Qdform)
                    .HasForeignKey(d => d.PdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QDForm_PDR");

                entity.HasOne(d => d.SignatureOfQdNavigation)
                    .WithMany(p => p.Qdform)
                    .HasForeignKey(d => d.SignatureOfQd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QDForm_PDRUsers");
            });

            modelBuilder.Entity<Qnform>(entity =>
            {
                entity.ToTable("QNForm");

                entity.HasIndex(e => e.PdrId);

                entity.HasIndex(e => e.SignatureOfQn);

                entity.Property(e => e.Bp)
                    .HasColumnName("BP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt)
                    .HasColumnName("HGT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hr)
                    .HasColumnName("HR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Intake)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ivrate)
                    .HasColumnName("IVRate")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.O2sat)
                    .HasColumnName("O2Sat")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rr)
                    .HasColumnName("RR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureOfQn).HasColumnName("SignatureOfQN");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfFluid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UrineOutput)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.Qnform)
                    .HasForeignKey(d => d.PdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QNForm_PDR");

                entity.HasOne(d => d.SignatureOfQnNavigation)
                    .WithMany(p => p.Qnform)
                    .HasForeignKey(d => d.SignatureOfQn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QNForm_PDRUsers");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.HasIndex(e => e.Pdrid);

                entity.HasIndex(e => e.ReferredBy);

                entity.Property(e => e.Pdrid).HasColumnName("PDRId");

                entity.Property(e => e.ReferredTo).IsRequired();

                entity.Property(e => e.ReferringQuarantineFacility).IsRequired();

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.Pdrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReferralTable_PDRTable");

                entity.HasOne(d => d.ReferredByNavigation)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.ReferredBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Referral_PDRUsers");
            });

            modelBuilder.Entity<TeamSchedule>(entity =>
            {
                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unusualities>(entity =>
            {
                entity.HasIndex(e => e.PdrId);

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pdr)
                    .WithMany(p => p.Unusualities)
                    .HasForeignKey(d => d.PdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Unusualities_PDR");
            });

            modelBuilder.Entity<UserTeams>(entity =>
            {
                entity.Property(e => e.Team)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
