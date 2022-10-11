using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RelativePerson
    {
        public RelativePerson()
        {
            Addresses = new HashSet<Address>();
            MedicalReimbursements = new HashSet<MedicalReimbursement>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public bool Active { get; set; }
        public string Nickname { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public int GenderEnum { get; set; }
        public int? BloodGroupEnum { get; set; }
        public string Occupation { get; set; } = null!;
        public bool StillAlive { get; set; }
        public string MobilePhoneNumber { get; set; } = null!;
        public string Workplace { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int? MarriedStatusEnum { get; set; }
        public string IdcardNumber { get; set; } = null!;
        public string Hometown { get; set; } = null!;
        public int? ReligionId { get; set; }
        public int? NameTitleId { get; set; }
        public int? NationalityId { get; set; }
        public int? RaceId { get; set; }
        public int StaffId { get; set; }
        public int? FamilialRelationshipId { get; set; }

        public virtual FamilialRelationship? FamilialRelationship { get; set; }
        public virtual NameTitle? NameTitle { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual Race? Race { get; set; }
        public virtual Religion? Religion { get; set; }
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<MedicalReimbursement> MedicalReimbursements { get; set; }
    }
}
