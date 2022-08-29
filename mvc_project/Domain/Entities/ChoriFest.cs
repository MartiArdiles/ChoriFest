using System;
using System.Collections.Generic;

namespace mvc_project.Entities
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
        //public int QuantityAssist { get; set; }
        public ChoriFest()
        {

        }

        public List<ChoriFest> CreateListChoriFest(int cantidad)
        {

            ChoriFest choriFest = new ChoriFest();
            List<ChoriFest> listChoriFest = new List<ChoriFest>();  
            //for (int i = 0; i < cantidad; i++)
            //{
            //    choriFest.NameChoriFest = "ChoriFest "+System.Convert.ToString(i);
            //    choriFest.DateChoriFest = System.Convert.ToDateTime("01/08/2022");
            //    choriFest.StateChoriFest = "Abierto";
            //    choriFest.MenuChoriFest = "Chorizo Mezcla o Vegano + Bebida";
            //    choriFest.RegistrationStart = System.Convert.ToDateTime("20/06/2022");
            //    choriFest.RegistrationEnd = System.Convert.ToDateTime("20/07/2022");
            //    choriFest.QuantityAssist = 10+i;
            //    listChoriFest.Add(choriFest);

            //}
            return listChoriFest;

        }
        

    }
}
