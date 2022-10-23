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
						
			Map(x => x.MenuId)
				.Column("MenuId");
			References(x => x.MenuId, "MenuId");
			Map(x => x.QtyMenu)
				.Column("QtyMenu");
			Map(x => x.DrinkId)
				.Column("DrinkId");
			Map(x => x.QtyDrink)
				.Column("QtyDrink");
			Map(x => x.ExtraId)
				.Column("ExtraId");
			Map(x => x.QtyExtra)
				.Column("QtyExtra");

		}
	}
}
