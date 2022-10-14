using entity_library.System.User;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.System.Assist
{
    public class DAOUser
    {
        private ISession session;

        public DAOUser(ISession session)
        {
            this.session = session;
        }
		public bool GetUser(string userName, string password)
		{
			try
			{
				var exist = session.QueryOver<User>().Where(x => x.Name == userName).List();

				return exist != null ? true : false;
				
			}
			catch (Exception ex)
			{
				throw new Exception("DAOlibrary.System.Assist.DAOUser.GetUser(long id): Error al obtener el item con id = " , ex);
			}
		}
	}
}
