using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.System.Assist
{
    public class AssistChoriFest
    {
        public int IdChoriFest { get; set; }
        public int IdAssist { get; set; }

        public int IdAssistMenu { get; set; }

        public bool Went { get; set; }
        public bool Payment { get; set; }
    }
}
