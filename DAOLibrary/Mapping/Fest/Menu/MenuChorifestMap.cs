using entity_library.Fest.Menu;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Fest.Menu
{
    public class MenuChorifestMap: ClassMap<MenuChorifest>
    {
		public MenuChorifestMap()
        {
            Table("menu-chorifest");
            Id(x => x.Id)
                .Column("Id")
                .GeneratedBy.Increment();

            
            References(x => x.Menu, "MenuId");

            
            References(x => x.Chorifest, "ChorifestId");

        }
    }
}
