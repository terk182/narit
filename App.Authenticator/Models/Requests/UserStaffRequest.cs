using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Authenticator.Models.Requests
{
    public class UserStaffRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public int? JobPositionId { get; set; }
        public string MobilePhoneNumber { get; set; } = null!;
        public string EMailAddress { get; set; }
    }
}
