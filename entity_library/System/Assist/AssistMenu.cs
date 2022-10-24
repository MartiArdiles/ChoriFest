using entity_library.Fest.Menu;
using entity_library.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.System.Assist
{
    public class AssistMenu
    {
        public virtual int Id { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual int QtyMenu { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual int QtyDrink { get; set; }
        public virtual Extra Extra { get; set; }
        public virtual int QtyExtra { get; set; }

    }
}
