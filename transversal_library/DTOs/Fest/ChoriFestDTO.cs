using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transversal_library.DTOs.Fest
{
    public class ChoriFestDTO
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public List<entity_library.Fest.Menu.MenuChorifest> menus { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }

    }
}
