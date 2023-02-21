using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transversal_library.DTOs.Fest;

namespace transversal_library.Interfaces.ChoriFest.ChoriFest
{
    public interface IChorifestService
    {
        public Task<IEnumerable<entity_library.Fest.Chorifest>> GetChorifestList();
        public Task Save(ChoriFestDTO chorifestDTO);

    }
}
