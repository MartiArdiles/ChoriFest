using entity_library.Products;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Product
{
    public class DrinkMap: ClassMap<Drink>
    {
		public DrinkMap()
		{
			Table("drink");
			Id(x => x.Id)
				.Column("Id")
				.GeneratedBy.Increment();

			Map(x => x.Name)
				.Column("name");

			Map(x => x.Description)
				.Column("description");

			Map(x => x.Price)
				.Column("price");


		}
	}
}
