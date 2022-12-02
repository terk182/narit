using App.Authenticator.Models.Dtos;
using App.Common.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Authenticator.Models.Responses
{
    public class AuthenticatorBaseResponse : CommonBaseResponse
    {
        public userData data { get; set; }
        public List<RolesGroupDto>? rolesGroup { get; set; }
        //public List<oldRolesPage>? oldPage { get; set; }
        // public userdetail userdetail { get; set; }
    }


    public class RolesGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    public class oldRolesPage
    {
        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string LoweredRoleName { get; set; } = null!;
        public string? Description { get; set; }
    }

    public class userData
    {
        public Guid userid { get; set; }
        public string? name { get; set; }
        public bool IsFinancialDepPowerUser { get; set; }
        public bool IsPlanDepPowerUser { get; set; }
        public bool IsProcureDepPowerUser { get; set; }
        public bool IsHrdepPowerUser { get; set; }
        public bool IsFilingDepPowerUser { get; set; }
    }
}
