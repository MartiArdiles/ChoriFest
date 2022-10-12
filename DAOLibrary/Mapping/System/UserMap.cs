using entity_library.System.User;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Mapping.System
{
    public class UserMap : ClassMap<User>
    {
		public UserMap()
		{
			Table("User");
			Id(x => x.Id)
				.Column("IdUser")
				.GeneratedBy.Increment();

			Map(x => x.Name)
				.Column("Name");

			Map(x => x.Surname)
				.Column("Surname");

			Map(x => x.Password)
				.Column("Password");
			Map(x => x.Email)
				.Column("Email");
			Map(x => x.Rol)
				.Column("Rol");
		}
	}
}
