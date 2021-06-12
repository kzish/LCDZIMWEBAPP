using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MobileApi.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CareReportCareGiver> CareReportCareGiver { get; set; }
        public virtual DbSet<CaseReport> CaseReport { get; set; }
        public virtual DbSet<CaseReportClientInformation> CaseReportClientInformation { get; set; }
        public virtual DbSet<CaseReportDescriptionOfTheCaseProblem> CaseReportDescriptionOfTheCaseProblem { get; set; }
        public virtual DbSet<CaseReportJustificationReportForAttendedCases> CaseReportJustificationReportForAttendedCases { get; set; }
        public virtual DbSet<CaseReportNeedsAssesment> CaseReportNeedsAssesment { get; set; }
        public virtual DbSet<CaseReportNextOfKin> CaseReportNextOfKin { get; set; }
        public virtual DbSet<CaseReportParentsGuardiansSpousesInformation> CaseReportParentsGuardiansSpousesInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=LCDZIM;User Id=sa;Password=123abc!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<CareReportCareGiver>(entity =>
            {
                entity.ToTable("care_report.care_giver");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CareGiverAddress)
                    .HasColumnName("care_giver_address")
                    .IsUnicode(false);

                entity.Property(e => e.CareGiverDob)
                    .HasColumnName("care_giver_dob")
                    .HasColumnType("date");

                entity.Property(e => e.CareGiverName)
                    .HasColumnName("care_giver_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CareGiverPhoneNumber)
                    .HasColumnName("care_giver_phone_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CareGiverSex)
                    .HasColumnName("care_giver_sex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseReport>(entity =>
            {
                entity.ToTable("case_report");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("case_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompiledBy)
                    .HasColumnName("compiled_by")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourtHandlingTheCase)
                    .HasColumnName("court_handling_the_case")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CrRef)
                    .HasColumnName("cr_ref")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCaseWasReported)
                    .HasColumnName("date_case_was_reported")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCompiled)
                    .HasColumnName("date_compiled")
                    .HasColumnType("datetime");

                entity.Property(e => e.ForceNumber)
                    .HasColumnName("force_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("mobile_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfInvestigatingOfficer)
                    .HasColumnName("name_of_investigating_officer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PoliceStation)
                    .HasColumnName("police_station")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredByNameAndInstitution)
                    .HasColumnName("referred_by_name_and_institution")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseReportClientInformation>(entity =>
            {
                entity.ToTable("case_report.client_information");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientsAddress)
                    .HasColumnName("clients_address")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfDisability)
                    .HasColumnName("description_of_disability")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.GiveDetailsOfTheDisability)
                    .HasColumnName("give_details_of_the_disability")
                    .IsUnicode(false);

                entity.Property(e => e.LevelOfEducation)
                    .HasColumnName("level_of_education")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClient)
                    .HasColumnName("name_of_client")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberHome)
                    .HasColumnName("phone_number_home")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseReportClientInformation)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_case_report.client_information_case_report.client_information");
            });

            modelBuilder.Entity<CaseReportDescriptionOfTheCaseProblem>(entity =>
            {
                entity.ToTable("case_report.description_of_the_case_problem");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BeneficiaryStatus)
                    .HasColumnName("beneficiary_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryStatusOtherSpecify)
                    .HasColumnName("beneficiary_status_other_specify")
                    .IsUnicode(false);

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsOfCaseAndCharge)
                    .HasColumnName("details_of_case_and_charge")
                    .IsUnicode(false);

                entity.Property(e => e.NatureOfTheMatterCase)
                    .HasColumnName("nature_of_the_matter_case")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NatureOfTheMatterCaseOtherSpecify)
                    .HasColumnName("nature_of_the_matter_case_other_specify")
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipClientAndAccused)
                    .HasColumnName("relationship_client_and_accused")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipClientAndSurvivorVictimComplainant)
                    .HasColumnName("relationship_client_and_survivor_victim_complainant")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipClientAndWitness)
                    .HasColumnName("relationship_client_and_witness")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseReportDescriptionOfTheCaseProblem)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_case_report.description_of_the_case_problem_case_report");
            });

            modelBuilder.Entity<CaseReportJustificationReportForAttendedCases>(entity =>
            {
                entity.ToTable("case_report.justification_report_for_attended_cases");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("approved_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedByDate)
                    .HasColumnName("approved_by_date")
                    .HasColumnType("date");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfCourtHearing)
                    .HasColumnName("date_of_court_hearing")
                    .HasColumnType("date");

                entity.Property(e => e.DateWhenTheBeneficiaryWasAssisted)
                    .HasColumnName("date_when_the_beneficiary_was_assisted")
                    .HasColumnType("date");

                entity.Property(e => e.NameOfBeneficiary)
                    .HasColumnName("name_of_beneficiary")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Outcome)
                    .HasColumnName("outcome")
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfActivity)
                    .HasColumnName("place_of_activity")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfOriginResidence)
                    .HasColumnName("place_of_origin_residence")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedBy)
                    .HasColumnName("prepared_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedByDate)
                    .HasColumnName("prepared_by_date")
                    .HasColumnType("date");

                entity.Property(e => e.SummaryOfActivity)
                    .HasColumnName("summary_of_activity")
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfAssistanceDisabilityExpert).HasColumnName("type_of_assistance_disability_expert");

                entity.Property(e => e.TypeOfAssistanceHomeVisit).HasColumnName("type_of_assistance_home_visit");

                entity.Property(e => e.TypeOfAssistanceLogisticalSupport).HasColumnName("type_of_assistance_logistical_support");
            });

            modelBuilder.Entity<CaseReportNeedsAssesment>(entity =>
            {
                entity.ToTable("case_report.needs_assesment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BeneficiaryImmediateConcerns)
                    .HasColumnName("beneficiary_immediate_concerns")
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryWellBeingAtThePointOfIntake)
                    .HasColumnName("beneficiary_well_being_at_the_point_of_intake")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryWellBeingAtThePointOfIntakeOtherSpecify)
                    .HasColumnName("beneficiary_well_being_at_the_point_of_intake_other_specify")
                    .IsUnicode(false);

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HowManyPeopleLiveWithTheBeneficiary).HasColumnName("how_many_people_live_with_the_beneficiary");

                entity.Property(e => e.HowManyPeopleLiveWithTheBeneficiaryRelation)
                    .HasColumnName("how_many_people_live_with_the_beneficiary_relation")
                    .IsUnicode(false);

                entity.Property(e => e.IfNoHowDoesHeSheCommunicate)
                    .HasColumnName("if_no_how_does_he_she_communicate")
                    .IsUnicode(false);

                entity.Property(e => e.IfNotWhatAssistanceIsNeededMovement)
                    .HasColumnName("if_not_what_assistance_is_needed_movement")
                    .IsUnicode(false);

                entity.Property(e => e.IsTheBeneficiaryAbleToMoveIndependently).HasColumnName("is_the_beneficiary_able_to_move_independently");

                entity.Property(e => e.IsTheBeneficiaryAbleToVerballyCommunicate).HasColumnName("is_the_beneficiary_able_to_verbally_communicate");

                entity.Property(e => e.OtherRelevantIssues)
                    .HasColumnName("other_relevant_issues")
                    .IsUnicode(false);

                entity.Property(e => e.WhereDoesTheBeneficiaryLive)
                    .HasColumnName("where_does_the_beneficiary_live")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoIsTakingCareOfTheBeneficiary)
                    .HasColumnName("who_is_taking_care_of_the_beneficiary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoIsTakingCareOfTheBeneficiaryOtherSpecify)
                    .HasColumnName("who_is_taking_care_of_the_beneficiary_other_specify")
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseReportNeedsAssesment)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_case_report.needs_assesment_case_report");
            });

            modelBuilder.Entity<CaseReportNextOfKin>(entity =>
            {
                entity.ToTable("case_report.next_of_kin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Employer)
                    .HasColumnName("employer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseReportNextOfKin)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_case_report.next_of_kin_case_report");
            });

            modelBuilder.Entity<CaseReportParentsGuardiansSpousesInformation>(entity =>
            {
                entity.ToTable("case_report.parents_guardians_spouses_information");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasColumnName("case_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Employer)
                    .HasColumnName("employer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("marital_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusOtherSpecify)
                    .HasColumnName("marital_status_other_specify")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseReportParentsGuardiansSpousesInformation)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_case_report.parents_guardians_spouses_information_case_report");
            });
        }
    }
}
