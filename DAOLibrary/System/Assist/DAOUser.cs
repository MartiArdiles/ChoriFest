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
				var User = session.QueryOver<User>().Where(x => x.Name == userName && x.Password==password).SingleOrDefault<User>();

				return User != null ? true : false;
				
			}
			catch (Exception ex)
			{
				throw new Exception("DAOlibrary.System.Assist.DAOUser.GetUser(long id): Error al obtener el item con id = " , ex);
			}
		}
		public void SaveUser(User item)
		{
			try
			{
				this.session.Save(item);
			}
			catch (Exception ex)
			{
				throw new Exception("dao_library.System.DAOUser.Save: Error al guardar el item.", ex);
			}
		}
	}
}
