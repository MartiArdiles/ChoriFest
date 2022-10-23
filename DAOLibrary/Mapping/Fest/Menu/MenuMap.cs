using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Fest.Menu
{
    public class MenuMap : ClassMap<entity_library.Fest.Menu.Menu>
    {
		public MenuMap()
		{
			Table("menu");
			Id(x => x.Id)
				.Column("Id")
				.GeneratedBy.Increment();

			Map(x => x.Food)
				.Column("FoodId");
			References(x => x.Food, "FoodId");

		}
    }
}
