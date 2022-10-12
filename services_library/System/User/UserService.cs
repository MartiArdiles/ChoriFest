using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transversal_library.Interfaces.System.User;

namespace services_library.System.User
{
    public class UserService: IUserService
    {
        var userDAO = new DAOFActory();
        public bool GetUser(string userName, string password)
        {

            return true;

        }
    }
}
