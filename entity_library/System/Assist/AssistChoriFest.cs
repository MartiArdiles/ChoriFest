using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_library.Fest;

namespace entity_library.System.Assist
{
    public class AssistChoriFest
    {
        public virtual int Id { get; set; }
        
        public virtual Chorifest ChorifestList { get; set; }
        public virtual Assist AssistList { get; set; }

        public virtual AssistMenu IdAssistMenu { get; set; }

        public virtual bool Went { get; set; }
        public virtual bool Payment { get; set; }
    }
}
