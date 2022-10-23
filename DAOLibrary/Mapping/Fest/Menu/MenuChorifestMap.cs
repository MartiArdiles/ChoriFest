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

            Map(x => x.MenuId)
                .Column("MenuId");
            References(x => x.MenuId, "MenuId");

            Map(x => x.ChorifestId)
                .Column("ChorifestId");
            References(x => x.ChorifestId, "ChorifestId");

        }
    }
}
