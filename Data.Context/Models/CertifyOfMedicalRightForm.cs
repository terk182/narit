using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class CertifyOfMedicalRightForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public int RequesterStaffId { get; set; }
        public string RequesterDepartmentName { get; set; } = null!;
        public int RequesterDepartmentId { get; set; }
        public string RequesterPosition { get; set; } = null!;
        public int ObjectiveTypeEnum { get; set; }
        public string AttachmentTypeEnumListValue { get; set; } = null!;
        public string IdcardNumber { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public bool IsSameAddress { get; set; }
        public int? Age { get; set; }
        public int FamilyRelationTypeEnum { get; set; }
    }
}
