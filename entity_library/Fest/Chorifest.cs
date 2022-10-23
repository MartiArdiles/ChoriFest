using entity_library.Fest.StatesChoriFest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.Fest
{
    public class Chorifest
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime RegistrationStart { get; set; }
        public virtual DateTime RegistrationEnd { get; set; }
        public virtual State StateChorifest { get; set; }
        public virtual int QuantityAssist { get; set; }
        //public ChoriFest()
        //{

        //}

        //public List<ChoriFest> CreateListChoriFest(int cantidad)
        //{

        //    ChoriFest choriFest = new ChoriFest();
        //    List<ChoriFest> listChoriFest = new List<ChoriFest>();
        //    for (int i = 0; i < cantidad; i++)
        //    {
        //        choriFest.Title = "ChoriFest " + Convert.ToString(i);
        //        choriFest.Date = Convert.ToDateTime("01/08/2022");
        //        choriFest.State = "Abierto";
        //        choriFest.Menu = "Chorizo Mezcla o Vegano + Bebida";
        //        choriFest.RegistrationStart = Convert.ToDateTime("20/06/2022");
        //        choriFest.RegistrationEnd = Convert.ToDateTime("20/07/2022");
        //        listChoriFest.Add(choriFest);

        //    }
        //    return listChoriFest;

        //}

    }
}
