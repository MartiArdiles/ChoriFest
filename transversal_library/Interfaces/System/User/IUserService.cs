using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transversal_library.Interfaces.System.User
{
    public interface IUserService
    {
        public bool GetUser(string userName, string password);
    }
}
