using entity_library.Fest.StatesChoriFest;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Fest
{
    public class StateMap: ClassMap<State>
    {
		public StateMap()
		{
			Table("state-chorifest");
			Id(x => x.Id)
				.Column("Id")
				.GeneratedBy.Increment();

			Map(x => x.Title)
				.Column("Title");
			Map(x => x.Description)
				.Column("Description");

		}
	}
}
