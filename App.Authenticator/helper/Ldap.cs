using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
namespace App.Authenticator.helper
{
    public class Ldap
    {
        public DirectoryEntry createDirectoryEntry(string domain, string Path,string username,string password)
        {
          
            var ldapConnection = new DirectoryEntry(domain);
            ldapConnection.Path = Path;
            ldapConnection.Username = username;
            ldapConnection.Password = password;

            ldapConnection.AuthenticationType = AuthenticationTypes.Signing;

            return ldapConnection;
        }

    }
}
