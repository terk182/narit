using narit_mis_api.Models;
using App.Authenticator.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Authenticator.Models.Requests;
using Microsoft.Extensions.Configuration;
using System.Reflection.PortableExecutable;
using App.Authenticator.helper;
using System.DirectoryServices;
using App.Authenticator.Models.Dtos;
using App.Authenticator.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace App.Authenticator
{
    public class AuthenticatorServices : IAuthenticatorServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        private readonly IConfiguration Configuration;
        private string _LdapDomain;
        private string _LdapServerIp;
        public AuthenticatorServices(NARIT_MIS_LINKContext context, IConfiguration configuration)
        {
            Configuration = configuration;
            _database = context;
            _LdapDomain = Configuration["Ldap:LdapDomain"];
            _LdapServerIp = Configuration["Ldap:IpLdapSever"];
        }

      

        public List<StaffDto> getAllUser()
        {
            var result = new List<StaffDto>();
            var data = _database.Staffs.Where(c => c.Active).ToList();
            var hrdepartmentname = _database.Hrdepartments.Where(c => c.Active).ToList();
            var jobpostion = _database.JobPositions.Where(c => c.Active).ToList();
            var QSOuterJoin = from user in data
                              join department in hrdepartmentname
                              on user.HrdepartmentId equals department.Id
                              into UserDepartmentGroup
                              from address in UserDepartmentGroup.DefaultIfEmpty()
                              join jobposi in jobpostion
                              on user.JobPositionId equals jobposi.Id
                              into JobPositionGroup
                              from wherejobposi in JobPositionGroup.DefaultIfEmpty()
                              select new { user, address, wherejobposi };

            foreach (var item in QSOuterJoin)
            {
                result.Add(new StaffDto
                {
                    Name = item.user.Name,
                    Surname = item.user.Surname,
                    EMailAddress = item.user.EMailAddress,
                    ImageUrl = item.user.ImageUrl,
                    HrdepartmentId = item.user.HrdepartmentId,
                    StaffId = item.user.Id,
                    WorkStatusEnum = item.user.WorkStatusEnum,
                    //WorkStatusEnum สถานะการทำงาน
                    //< asp:ListItem Text = "ปฏิบัติงาน" Value = "10" ></ asp:ListItem >
                    //< asp:ListItem Text = "ลาออก" Value = "20" ></ asp:ListItem >
                    //< asp:ListItem Text = "ทดลองงาน" Value = "30" ></ asp:ListItem >
                    //< asp:ListItem Text = "ศึกษาต่อ" Value = "40" ></ asp:ListItem >
                    //< asp:ListItem Text = "พักงาน" Value = "50" ></ asp:ListItem >
                    WorkStatus = item.user.WorkStatusEnum == 10 ? "ปฏิบัติงาน" : item.user.WorkStatusEnum == 20 ? "ลาออก" : item.user.WorkStatusEnum == 30 ? "ทดลองงาน" : item.user.WorkStatusEnum == 40 ? "ศึกษาต่อ" : item.user.WorkStatusEnum == 50 ? "พักงาน" : "ไม่ปรากฎข้อมูล",
                    Hrdepartmentname = item.address?.Name,
                    MobilePhoneNumber = item.user.MobilePhoneNumber,
                    PositionName = item.wherejobposi?.Name,
                    JobPositionId = item.user.JobPositionId

                    //AspnetUsersUserId = item.,
                    //UserName = item.
                    //AccessRight = item.
                });
                

            }
           
            return result;
        }

        public List<StaffDto> getUserId(int id)
        {
            var result = new List<StaffDto>();
            var data = _database.Staffs.Where(c => c.Id == id).ToList();
            var hrdepartmentname = _database.Hrdepartments.Where(c => c.Active).ToList();
            var jobpostion = _database.JobPositions.Where(c => c.Active).ToList();
            var QSOuterJoin = from user in data
                              join department in hrdepartmentname
                              on user.HrdepartmentId equals department.Id
                              into UserDepartmentGroup
                              from address in UserDepartmentGroup.DefaultIfEmpty()
                              join jobposi in jobpostion
                              on user.JobPositionId equals jobposi.Id
                              into JobPositionGroup
                              from wherejobposi in JobPositionGroup.DefaultIfEmpty()
                              select new { user, address, wherejobposi };

            foreach (var item in QSOuterJoin)
            {
                result.Add(new StaffDto
                {
                    Name = item.user.Name,
                    Surname = item.user.Surname,
                    EMailAddress = item.user.EMailAddress,
                    ImageUrl = item.user.ImageUrl,
                    HrdepartmentId = item.user.HrdepartmentId,
                    StaffId = item.user.Id,
                    WorkStatusEnum = item.user.WorkStatusEnum,
                    //WorkStatusEnum สถานะการทำงาน
                    //< asp:ListItem Text = "ปฏิบัติงาน" Value = "10" ></ asp:ListItem >
                    //< asp:ListItem Text = "ลาออก" Value = "20" ></ asp:ListItem >
                    //< asp:ListItem Text = "ทดลองงาน" Value = "30" ></ asp:ListItem >
                    //< asp:ListItem Text = "ศึกษาต่อ" Value = "40" ></ asp:ListItem >
                    //< asp:ListItem Text = "พักงาน" Value = "50" ></ asp:ListItem >
                    WorkStatus = item.user.WorkStatusEnum == 10 ? "ปฏิบัติงาน" : item.user.WorkStatusEnum == 20 ? "ลาออก" : item.user.WorkStatusEnum == 30 ? "ทดลองงาน" : item.user.WorkStatusEnum == 40 ? "ศึกษาต่อ" : item.user.WorkStatusEnum == 50 ? "พักงาน" : "ไม่ปรากฎข้อมูล",
                    Hrdepartmentname = item.address?.Name,
                    MobilePhoneNumber = item.user.MobilePhoneNumber,
                    PositionName = item.wherejobposi?.Name,
                    JobPositionId = item.user.JobPositionId
                    //AspnetUsersUserId = item.,
                    //UserName = item.
                    //AccessRight = item.
                });


            }

            return result;
        }
        public UserResponse deleteUser(int id)
        {
            var response = new UserResponse();
            var data = _database.Staffs.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                _database.Remove(data);
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }

        public LdapAuthenticatorBaseResponse LdapLogIn(AuthenticatorRequest request)
        {
            var respone = new LdapAuthenticatorBaseResponse();
            var user_data = new List<LdapData>();
            var _Ldap = new Ldap();
            string result_txt = "";

            try
            {
                System.DirectoryServices.DirectoryEntry myLdapConnection = _Ldap.createDirectoryEntry(_LdapServerIp, _LdapDomain, request.UserName, request.Password);
                DirectorySearcher search = new DirectorySearcher(myLdapConnection);
                search.Filter = "(cn=" + request.UserName + ")";

                // create an array of properties that we would like and  
                // add them to the search object  

                string[] requiredProperties = new string[] { "cn", "mail" };

                foreach (String property in requiredProperties)
                    search.PropertiesToLoad.Add(property);

                SearchResult result = search.FindOne();

                if (result != null)
                {
                    foreach (String property in requiredProperties)
                    {
                        foreach (Object myCollection in result.Properties[property])
                        {
                            user_data.Add(new LdapData
                            {
                                property = property,
                                data = myCollection.ToString()
                            });
                            //result_txt = String.Format("{0,-20} : {1}", property, myCollection.ToString());
                        }
                    }
                    respone.Success = user_data.Count() > 0 ? true : false;
                    respone.Messsage = "success";
                }

                else {
                    respone.Success = false;
                    respone.Messsage = "not found";
                }
               
            }

            catch (Exception e)
            {
                respone.Success = false;
                respone.Errors = e.Message;
            }

            respone.data = user_data;
            return respone;
        }

        public AuthenticatorBaseResponse LogIn(AuthenticatorRequest request)
        {
            int checknullusername;
            int checknullpassword;
            Guid checkUserIdofUsername;
            Guid checkUserIdofPassword;
            var datausername = _database.AspnetUsers.Where(x => x.UserName == request.UserName).FirstOrDefault();
            if (datausername == null) { checknullusername = 0; }
            else { checknullusername = 1; }
            if (checknullusername == 0)
            {
                checkUserIdofUsername = Guid.Empty;
            }
            else
            {
                checkUserIdofUsername = datausername.UserId;
            }
            var datapassword = _database.AspnetMemberships.Where(x => x.Password == request.Password).FirstOrDefault();
            if (datapassword == null) { checknullpassword = 0; }
            else { checknullpassword = 1; }
            if (checknullpassword == 0)
            {
                checkUserIdofPassword = Guid.Empty;
            }
            else
            {
                checkUserIdofPassword = datapassword.UserId;
            }
            var response = new AuthenticatorBaseResponse();
            if (checkUserIdofUsername == checkUserIdofPassword && checkUserIdofUsername != Guid.Empty && checkUserIdofPassword != Guid.Empty)
            {
                response.Success = true;
                response.Messsage = "Congrats";
              //  response.userid = checkUserIdofUsername;

            }
            else if (checkUserIdofUsername == Guid.Empty && checkUserIdofPassword != Guid.Empty)
            {
                response.Success = false;
                response.Messsage = "Your username is wrong";
            }
            else if (checkUserIdofUsername != Guid.Empty && checkUserIdofPassword == Guid.Empty)
            {
                response.Success = false;
                response.Messsage = "Your password is wrong";
            }
            else
            {
                response.Success = false;
                response.Messsage = "Your username and password are wrong";
            }
            return response;
        }

        public AuthenticatorBaseResponse LogInCheck(AuthenticatorRequest request)
        {
            var response = new AuthenticatorBaseResponse();
          
            var datausername = _database.AspnetUsers.Where(x => x.UserName == request.UserName).Include(x => x.StaffSecurities).FirstOrDefault();
            if (datausername == null) 
            {
                response.Success = false;
                response.Messsage = "Your username is wrong";
                return response;
            }
           
            var datapassword = _database.AspnetMemberships.Where(x => x.Password == request.Password).FirstOrDefault();

            if (datapassword == null) 
            {
                response.Success = false;
                response.Messsage = "Your password is wrong";
                return response;
            }

            var _staffSecurityRolesGroup = new StaffSecurityRolesGroupDirect(Configuration);
            int id = datausername.StaffSecurities.Select(x => x.Id).FirstOrDefault();
            var _staffSecurityRolesData = _staffSecurityRolesGroup.GetAll_data(id);
            var id_list = new List<int>();
            foreach(var item in _staffSecurityRolesData)
            {
                id_list.Add(item.RolesGroups_Id);
            }
            var _RolesGroups = _database.RolesGroups.Where(x => id_list.Contains(x.Id)).Include(x => x.AspnetRolesRoles).ToList();
            var rolesGroupDto = new List<RolesGroupDto>();
            foreach (var item1 in _RolesGroups)
            {
                rolesGroupDto.Add(new RolesGroupDto
                {
                    Id = item1.Id,
                    Name = item1.Name
                });
            }
            if (true)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "https://localhost:5001",
                    audience: "https://localhost:5001",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                response.token = new AuthenticatedResponse { Token = tokenString };
                //return Ok(new AuthenticatedResponse { Token = tokenString });
            }

            //var oldMisPage = new List<oldRolesPage>();


            //foreach (var item2 in _RolesGroups.SelectMany(x => x.AspnetRolesRoles))
            //{
            //    oldMisPage.Add(new oldRolesPage { 
            //        ApplicationId = item2.ApplicationId,
            //        RoleId = item2.RoleId,
            //        RoleName = item2.RoleName,
            //        LoweredRoleName = item2.LoweredRoleName,
            //        Description = item2.Description,
            //    });
            //}

            var user = new userData();
            user.userid = datapassword.UserId;
            user.name = datausername.StaffSecurities.Select(x => x.Name).FirstOrDefault();
            user.StaffId = datausername.StaffSecurities.Select(x => x.StaffId).FirstOrDefault();
            user.IsFinancialDepPowerUser = datausername.StaffSecurities.Select(x => x.IsFinancialDepPowerUser).FirstOrDefault();
            user.IsPlanDepPowerUser = datausername.StaffSecurities.Select(x => x.IsPlanDepPowerUser).FirstOrDefault();
            user.IsProcureDepPowerUser = datausername.StaffSecurities.Select(x => x.IsProcureDepPowerUser).FirstOrDefault();
            user.IsHrdepPowerUser = datausername.StaffSecurities.Select(x => x.IsHrdepPowerUser).FirstOrDefault();
            user.IsFilingDepPowerUser = datausername.StaffSecurities.Select(x => x.IsFilingDepPowerUser).FirstOrDefault();
            user.IsPDPA = datausername.StaffSecurities.Select(x => x.IsPdpa).FirstOrDefault();

            response.Success = true;
            response.Messsage = "Congrats";
            response.data = user;
            response.rolesGroup = rolesGroupDto;
            return response;
       
        }

        public AuthenticatorBaseResponse PDPASetup(PDPADto request)
        {

            var response = new AuthenticatorBaseResponse();
            var data = _database.StaffSecurities.FirstOrDefault(x => x.StaffId == request.StaffId);
            if (data != null)
            {
                data.IsPdpa = request.IsPdpa;

                _database.Entry(data).State = EntityState.Modified;

                int returnValue = _database.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "update complete" : "update error";

            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";

            }

            response.Success = true;

            return response;
        }
    }
}
