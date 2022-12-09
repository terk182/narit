using App.Authenticator.helper.models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Authenticator.helper
{
    public class StaffSecurityRolesGroupDirect
    {

     
        private readonly string contextDb;
        public StaffSecurityRolesGroupDirect(IConfiguration configuration)
        {
            contextDb = configuration.GetConnectionString("Defaultconnectton");
        }

        public List<StaffSecurityRolesGroupModel> GetAll_data(int StaffSecurities_Id)
        {

            string sql = "";


            sql = String.Format("select * from StaffSecurityRolesGroup where StaffSecurities_Id = '{0}'", StaffSecurities_Id);


            var StaffSecurityRolesList = new List<StaffSecurityRolesGroupModel>();

            using (SqlConnection sqlconn = new SqlConnection(contextDb))
            {
                sqlconn.Open();

                SqlCommand command;
                SqlDataReader dataReader;




                command = new SqlCommand(sql, sqlconn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    StaffSecurityRolesList.Add(new StaffSecurityRolesGroupModel
                    {
                        StaffSecurities_Id = (int)dataReader["StaffSecurities_Id"],
                        RolesGroups_Id = (int)dataReader["RolesGroups_Id"],

                    });


                }

                sqlconn.Close();


            }
            return StaffSecurityRolesList;

        }
    }
}
