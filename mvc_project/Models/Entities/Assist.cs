namespace mvc_project.Models.Entities
{
    public class Assist
    {
        public int IdGuest { get; set; }
        public int IdChoriFest { get; set; }

        public int IdMenu { get; set; }
        public bool Went { get; set; }
        public bool Payment { get; set; }
    }
}
