using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.Fest.Menu
{
    public class MenuChorifest
    {
        public virtual int Id { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Chorifest Chorifest { get; set; }
    }
}
