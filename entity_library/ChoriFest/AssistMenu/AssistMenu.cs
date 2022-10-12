using entity_library.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.ChoriFest.AssistMenu
{
    public class AssistMenu
    {
        public int Id { get; set; }
        public int AssistId { get; set; }
        public int ChoriFestId { get; set; }
        
        public List<Food> FoodChoice   { get; set; }
        public List<Drink> DrinkChoice { get; set; }
        public List<Extra> ExtraChoice { get; set; }
    }
}
