namespace mvc_project.Models.Entities
{
    public class Assist
    {
        public int IdChoriFest { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int IdMenu { get; set; }
        public bool Went { get; set; }
        public bool Payment { get; set; }
    }
}
