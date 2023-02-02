using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ViewUserShowDetail
    {
        public Guid Uuid { get; set; }
        public int? UserTypeId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public byte Active { get; set; }
        public byte IsPdpa { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Emailaddress { get; set; }
        public string? ImageUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Departmentsid { get; set; }
        public int? JobPositionsid { get; set; }
        public int? WorkStatusid { get; set; }
        public string? Role { get; set; }
        public string? DepartmentName { get; set; }
        public string? JobPositionName { get; set; }
    }
}
