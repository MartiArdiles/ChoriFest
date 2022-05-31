using System;

namespace mvc_project.Models.Entities
{
    public class ChoriFest
    {
        public int IdChoriFest { get; set; }
        public DateTime DateChoriFest { get; set; }
        public string NameChoriFest { get; set; }
        public string StateChoriFest { get; set; }
        public string MenuChoriFest { get; set; }
        public string DescriptionChoriFest { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public int QuantityAssist { get; set; }
        public ChoriFest()
        {

        }
        

    }
}
