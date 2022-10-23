using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.Fest.Assist
{
    public class AssistMap: ClassMap<entity_library.System.Assist.Assist>
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
				.Column("Email");
			Map(x => x.Phone)
				.Column("Phone");
			

		}
	}
}
