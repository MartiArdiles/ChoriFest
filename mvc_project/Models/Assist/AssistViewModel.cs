using entity_library.Products;
using System.Collections.Generic;

namespace mvc_project.Models.Assist
{
    public class AssistViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public int IdChoriFest { get; set; }
                
        public List<Food> FoodChoice { get; set; }
        public List<Drink> DrinkChoice { get; set; }
        public List<Extra> ExtraChoice { get; set; }


    }
}
