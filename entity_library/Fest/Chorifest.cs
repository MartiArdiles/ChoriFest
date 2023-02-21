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
        public virtual int StateChorifest { get; set; }
        public virtual int QuantityAssist { get; set; }

        //private Chorifest()
        //{

        //}
        //public static Chorifest _chorifest;
        //public static Chorifest GetChoriFest()
        //{
        //    if (_chorifest == null)
        //    {
        //        return _chorifest = new Chorifest();
        //    }
        //    else
        //    {
        //        return _chorifest;
        //    }

        //}

        //private State SetState(int state)
        //{
        //    var ChoriState= State.
        //}

        
    }
}
