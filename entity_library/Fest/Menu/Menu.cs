using entity_library.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.Fest.Menu
{
    public class Menu
    {
        public virtual int Id { get; set; }
        public virtual Food Food { get; set; }
        
    }
}
