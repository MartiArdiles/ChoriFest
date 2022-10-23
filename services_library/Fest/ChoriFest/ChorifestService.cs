using DAOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transversal_library.Interfaces.ChoriFest.ChoriFest;

namespace services_library.Fest.ChoriFest
{
    public class ChorifestService : IChorifestService
    {
        public async Task<IEnumerable<entity_library.Fest.Chorifest>> GetChorifestList()
        {
            using (DAOFactory df = new DAOFactory())
            {
                return await df.DAOChorifest.GetListChorifest();

            }
        }
    }
}
