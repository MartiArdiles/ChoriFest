using entity_library.Products;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Product
{
    public class FoodMap: ClassMap<Food>
    {
		public FoodMap()
		{
			Table("food");
			Id(x => x.Id)
				.Column("Id")
				.GeneratedBy.Increment();

			Map(x => x.Name)
				.Column("Name");

			Map(x => x.Description)
				.Column("Description");

			Map(x => x.Price)
				.Column("Price");


		}
	}
}
