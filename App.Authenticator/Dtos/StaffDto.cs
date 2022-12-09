using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Authenticator.Dtos
{
    public class StaffDto
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string EMailAddress { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        //public string HrdepartmentName { get; set; }
        public int StaffId { get; set; }
        public Guid? AspnetUsersUserId { get; set; }
        public string UserName { get; set; } = null!;
        public int WorkStatusEnum { get; set; }
        public string WorkStatus { get; set; }
        public int AccessRight { get; set; }
        public string  Hrdepartmentname { get; set; }
        public string MobilePhoneNumber { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public int? JobPositionId { get; set; }
    }
}
