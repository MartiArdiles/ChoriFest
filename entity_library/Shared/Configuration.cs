using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_library.Shared
{
    public class Configuration
    {
        private static Configuration configuracion;

        private Configuration()
        {

        }

        public static Configuration Instance
        {
            get
            {
                if (configuracion == null)
                {
                    configuracion = new Configuration();
                }

                return configuracion;
            }
        }

        public string DefaultStringConnection { get; set; }
    }
}
