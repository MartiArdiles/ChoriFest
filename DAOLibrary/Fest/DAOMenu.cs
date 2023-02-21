using entity_library.Fest.Menu;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Fest
{
    public class DAOMenu
    {

        private ISession session;

        public DAOMenu(ISession session)
        {
            this.session = session;
        }

		public async Task SaveMenuChoriFest(MenuChorifest MenuChori)
		{
			try
			{
				await this.session.SaveAsync(MenuChori);

			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Chorifest.DAOChorifest.SaveChorifest: Error al guardar el item.", ex);
			}
		}
	}
}
