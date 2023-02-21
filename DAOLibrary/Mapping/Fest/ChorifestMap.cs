using entity_library.Fest;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAOLibrary.Mapping.Fest
{
    public class ChorifestMap: ClassMap<Chorifest>
    {
		public ChorifestMap()
		{
			Table("chorifest");
			Id(x => x.Id)
				.Column("Id")
				.GeneratedBy.Increment();

			Map(x => x.Title)
				.Column("Title");

			Map(x => x.StateChorifest)
				.Column("State");

			Map(x => x.Date)
				.Column("Date");

			Map(x => x.RegistrationStart)
				.Column("RegistrationStart");

			Map(x => x.RegistrationEnd)
				.Column("RegistrationEnd");

			
			Map(x => x.Description)
				.Column("Description");

			Map(x => x.QuantityAssist)
				.Column("QuantityAssist");
						

		}
	}
}
