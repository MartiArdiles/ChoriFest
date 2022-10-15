using DAOLibrary;
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



        public bool GetUser(string userName, string password)
        {
            using (DAOFactory df = new DAOFactory())
            {
                return df.DAOUsuario.GetUser(userName, password);

            }
            
        }


    }
}
