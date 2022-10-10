using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Addresses = new HashSet<Address>();
            CompetencyEvaluationForms = new HashSet<CompetencyEvaluationForm>();
            DailyAttendanceRequestForms = new HashSet<DailyAttendanceRequestForm>();
            DailyAttendances = new HashSet<DailyAttendance>();
            DevelopmentRecordCancellations = new HashSet<DevelopmentRecordCancellation>();
            DevelopmentRecords = new HashSet<DevelopmentRecord>();
            EducationRecords = new HashSet<EducationRecord>();
            EmploymentContracts = new HashSet<EmploymentContract>();
            Insignia = new HashSet<Insignia>();
            InverseBoss = new HashSet<Staff>();
            InverseFirstEvaluatorStaff = new HashSet<Staff>();
            InverseSecondEvaluatorStaff = new HashSet<Staff>();
            JobDescriptions = new HashSet<JobDescription>();
            JobResponsibilities = new HashSet<JobResponsibility>();
            JobResponsibilityEvaluationForms = new HashSet<JobResponsibilityEvaluationForm>();
            JobResponsibilityExpectScores = new HashSet<JobResponsibilityExpectScore>();
            LeaveArchievedRecords = new HashSet<LeaveArchievedRecord>();
            Leaves = new HashSet<Leaf>();
            MedicalReimbursements = new HashSet<MedicalReimbursement>();
            OutsideDuties = new HashSet<OutsideDuty>();
            OutsideDutyCancellations = new HashSet<OutsideDutyCancellation>();
            OverTimeRatePerHours = new HashSet<OverTimeRatePerHour>();
            OverTimeRequestForms = new HashSet<OverTimeRequestForm>();
            PastDevelopmentRecords = new HashSet<PastDevelopmentRecord>();
            PerformanceYearlyEvaluationForms = new HashSet<PerformanceYearlyEvaluationForm>();
            PersonalAbilities = new HashSet<PersonalAbility>();
            RelativePeople = new HashSet<RelativePerson>();
            Secondments = new HashSet<Secondment>();
            StaffWorkShifts = new HashSet<StaffWorkShift>();
            TempYearlyEvaluation5859Scores = new HashSet<TempYearlyEvaluation5859Score>();
            WorkHistories = new HashSet<WorkHistory>();
            WorkShiftSwitchFormStaffs = new HashSet<WorkShiftSwitchForm>();
            WorkShiftSwitchFormSwitchedStaffs = new HashSet<WorkShiftSwitchForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public bool Active { get; set; }
        public string Nickname { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public int GenderEnum { get; set; }
        public string Hometown { get; set; } = null!;
        public int BloodGroupEnum { get; set; }
        public int MarriedStatusEnum { get; set; }
        public string PositionNumber { get; set; } = null!;
        public string TaxNumber { get; set; } = null!;
        public string SocialSecurityNumber { get; set; } = null!;
        public bool StillAlive { get; set; }
        public string IdcardNumber { get; set; } = null!;
        public string MobilePhoneNumber { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime? StartWorkingDate { get; set; }
        public int? HrdepartmentId { get; set; }
        public string EMailAddress { get; set; } = null!;
        public int? JobPositionTypeId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public int? ReligionId { get; set; }
        public int? NameTitleId { get; set; }
        public int? NationalityId { get; set; }
        public int? RaceId { get; set; }
        public string PositionName { get; set; } = null!;
        public int FingerScanNumber { get; set; }
        public bool IsSendHrapproveNotificationMail { get; set; }
        public bool IsAutoInsertDailyAttendance { get; set; }
        public int? BossId { get; set; }
        public string? EnglishName { get; set; }
        public string? EnglishSurname { get; set; }
        public string? SalaryEncrypted { get; set; }
        public string? AutoInsertDailyAttendanceDayListValue { get; set; }
        public bool? IsSendWeeklyAbsentNotificationEmail { get; set; }
        public int FingerScanForSqlnumber { get; set; }
        public int? FirstEvaluatorStaffId { get; set; }
        public int? SecondEvaluatorStaffId { get; set; }
        public int? JobFunctionalPositionId { get; set; }
        public int? JobPositionGroupId { get; set; }
        public int JobPositionWageTypeEnum { get; set; }
        public bool IsResigned { get; set; }
        public DateTime? IdcardIssueDate { get; set; }
        public DateTime? IdcardExpireDate { get; set; }
        public DateTime? LatestPositionStartDate { get; set; }
        public DateTime? WorkPermitIssueDate { get; set; }
        public DateTime? WorkPermitExpireDate { get; set; }
        public DateTime? VisaExpireDate { get; set; }
        public int MilitaryServiceStatusEnum { get; set; }
        public string MilitaryServiceStatusRemark { get; set; } = null!;
        public string WorkPermitNumber { get; set; } = null!;
        public string VisaNumber { get; set; } = null!;
        public string PassportNumber { get; set; } = null!;
        public string ReferencePerson1Name { get; set; } = null!;
        public string ReferencePerson1Relation { get; set; } = null!;
        public string ReferencePerson1PhoneNumber { get; set; } = null!;
        public string ReferencePerson2Name { get; set; } = null!;
        public string ReferencePerson2Relation { get; set; } = null!;
        public string ReferencePerson2PhoneNumber { get; set; } = null!;
        public int WorkStatusEnum { get; set; }
        public int? JobPositionId { get; set; }
        public DateTime? ResignedDate { get; set; }
        public string ResignedReason { get; set; } = null!;
        public string PersonalEmailAddress { get; set; } = null!;
        public string MotorcycleDriverLicenceNumber { get; set; } = null!;
        public DateTime? MotorcycleDriverLicenceIssueDate { get; set; }
        public DateTime? MotorcycleDriverLicenceExpiryDate { get; set; }
        public string GovernmentIdNumber { get; set; } = null!;
        public DateTime? GovernmentIdIssueDate { get; set; }
        public DateTime? GovernmentIdExpiryDate { get; set; }
        public string DriverLicenceNumber { get; set; } = null!;
        public DateTime? DriverLicenceIssueDate { get; set; }
        public DateTime? DriverLicenceExpiryDate { get; set; }
        public bool IsForTesting { get; set; }
        public bool? IsFirstEvaluatorForApprove { get; set; }
        public int? ProcureStoreLocationId { get; set; }

        public virtual Staff? Boss { get; set; }
        public virtual Staff? FirstEvaluatorStaff { get; set; }
        public virtual Hrdepartment? Hrdepartment { get; set; }
        public virtual JobFunctionalPosition? JobFunctionalPosition { get; set; }
        public virtual JobPosition? JobPosition { get; set; }
        public virtual JobPositionGroup? JobPositionGroup { get; set; }
        public virtual JobPositionLevel? JobPositionLevel { get; set; }
        public virtual JobPositionType? JobPositionType { get; set; }
        public virtual NameTitle? NameTitle { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual Race? Race { get; set; }
        public virtual Religion? Religion { get; set; }
        public virtual Staff? SecondEvaluatorStaff { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CompetencyEvaluationForm> CompetencyEvaluationForms { get; set; }
        public virtual ICollection<DailyAttendanceRequestForm> DailyAttendanceRequestForms { get; set; }
        public virtual ICollection<DailyAttendance> DailyAttendances { get; set; }
        public virtual ICollection<DevelopmentRecordCancellation> DevelopmentRecordCancellations { get; set; }
        public virtual ICollection<DevelopmentRecord> DevelopmentRecords { get; set; }
        public virtual ICollection<EducationRecord> EducationRecords { get; set; }
        public virtual ICollection<EmploymentContract> EmploymentContracts { get; set; }
        public virtual ICollection<Insignia> Insignia { get; set; }
        public virtual ICollection<Staff> InverseBoss { get; set; }
        public virtual ICollection<Staff> InverseFirstEvaluatorStaff { get; set; }
        public virtual ICollection<Staff> InverseSecondEvaluatorStaff { get; set; }
        public virtual ICollection<JobDescription> JobDescriptions { get; set; }
        public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; }
        public virtual ICollection<JobResponsibilityEvaluationForm> JobResponsibilityEvaluationForms { get; set; }
        public virtual ICollection<JobResponsibilityExpectScore> JobResponsibilityExpectScores { get; set; }
        public virtual ICollection<LeaveArchievedRecord> LeaveArchievedRecords { get; set; }
        public virtual ICollection<Leaf> Leaves { get; set; }
        public virtual ICollection<MedicalReimbursement> MedicalReimbursements { get; set; }
        public virtual ICollection<OutsideDuty> OutsideDuties { get; set; }
        public virtual ICollection<OutsideDutyCancellation> OutsideDutyCancellations { get; set; }
        public virtual ICollection<OverTimeRatePerHour> OverTimeRatePerHours { get; set; }
        public virtual ICollection<OverTimeRequestForm> OverTimeRequestForms { get; set; }
        public virtual ICollection<PastDevelopmentRecord> PastDevelopmentRecords { get; set; }
        public virtual ICollection<PerformanceYearlyEvaluationForm> PerformanceYearlyEvaluationForms { get; set; }
        public virtual ICollection<PersonalAbility> PersonalAbilities { get; set; }
        public virtual ICollection<RelativePerson> RelativePeople { get; set; }
        public virtual ICollection<Secondment> Secondments { get; set; }
        public virtual ICollection<StaffWorkShift> StaffWorkShifts { get; set; }
        public virtual ICollection<TempYearlyEvaluation5859Score> TempYearlyEvaluation5859Scores { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormStaffs { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormSwitchedStaffs { get; set; }
    }
}
