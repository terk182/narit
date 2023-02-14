using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ContactPerson
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string? PersonPrefix { get; set; }
        public string? PersonName { get; set; }
        public string? PersonSurname { get; set; }
        public string? PersonNickname { get; set; }
        public int? PersonPhone { get; set; }
        public string? PersonEmail { get; set; }
        public string? PersonDepartment { get; set; }
        public string? PersonJobPosition { get; set; }
    }
}
