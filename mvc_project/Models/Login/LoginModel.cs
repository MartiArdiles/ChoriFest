using System.Collections.Generic;

namespace mvc_project.Models.Login
{
    public class LoginModel
    {
        public string userName { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        public string password { get; set; }
        public List<LoginModel> CargarPersonasLogin(int cantidad)
        {
            List<LoginModel> personas = new List<LoginModel>();
            LoginModel login;
            for (var i = 0; i < 10; i++)
            {
                login = new LoginModel();
                login.name = "Diego " + i.ToString();
                login.surname = "Perez";
                login.email = "ejemplo" + i.ToString() + "@gmail.com";
                personas.Add(login);

            }
            return personas;
        }
    }
}
