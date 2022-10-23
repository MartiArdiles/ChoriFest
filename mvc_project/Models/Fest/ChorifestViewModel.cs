using System;

namespace mvc_project.Models.Fest
{
    public class ChorifestViewModel
    {   
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int[] Menu { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
    }
}
