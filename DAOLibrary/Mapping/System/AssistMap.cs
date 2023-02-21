using entity_library.System.Assist;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.System
{
    public class AssistMap: ClassMap<Assist>
    {
		public AssistMap()
		{
			Table("assist");
			Id(x => x.Id)
				.Column("id")
				.GeneratedBy.Increment();

			Map(x => x.Name)
				.Column("Name");

			Map(x => x.Email)
				.Column("Surname");

			Map(x => x.Phone)
				.Column("Password");
		}
	}
}
