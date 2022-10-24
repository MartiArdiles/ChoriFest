using entity_library.System.Rol;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.System
{
    public class RolMap: ClassMap<Rol>
    {
		public RolMap()
		{
			Table("rol");
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
