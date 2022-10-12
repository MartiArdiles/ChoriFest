using entity_library.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.ChoriFest.Menu
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Food> Foods { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Extra> Extra { get; set; }
    }
}
