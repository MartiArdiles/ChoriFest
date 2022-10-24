using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_library.System.Assist;

namespace DAOLibrary.Mapping.Fest.AssistMenu
{
    public class AssistMenuMap: ClassMap<entity_library.System.Assist.AssistMenu>
    {
		public AssistMenuMap()
		{
			Table("assist-menu");
			Id(x => x.Id)
				.Column("id")
				.GeneratedBy.Increment();
			
			References(x => x.Menu, "MenuId");

			Map(x => x.QtyMenu)
				.Column("QtyMenu");
			
			References(x => x.Drink, "DrinkId");

			Map(x => x.QtyDrink)
				.Column("QtyDrink");

			
			References(x => x.Extra, "ExtraId");
			Map(x => x.QtyExtra)
				.Column("QtyExtra");

		}
	}
}
