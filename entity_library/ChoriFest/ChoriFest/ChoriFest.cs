using entity_library.ChoriFest.StatesChoriFest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.ChoriFest.ChoriFest
{
    public class ChoriFest
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public string Menu { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public State StateChorifest { get; set; }
        //public int QuantityAssist { get; set; }
        public ChoriFest()
        {

        }

        public List<ChoriFest> CreateListChoriFest(int cantidad)
        {

            ChoriFest choriFest = new ChoriFest();
            List<ChoriFest> listChoriFest = new List<ChoriFest>();
            for (int i = 0; i < cantidad; i++)
            {
                choriFest.Title = "ChoriFest " + Convert.ToString(i);
                choriFest.Date = Convert.ToDateTime("01/08/2022");
                choriFest.State = "Abierto";
                choriFest.Menu = "Chorizo Mezcla o Vegano + Bebida";
                choriFest.RegistrationStart = Convert.ToDateTime("20/06/2022");
                choriFest.RegistrationEnd = Convert.ToDateTime("20/07/2022");
                listChoriFest.Add(choriFest);

            }
            return listChoriFest;

        }

    }
}
