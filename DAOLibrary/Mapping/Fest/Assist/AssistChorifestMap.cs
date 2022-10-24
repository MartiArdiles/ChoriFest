using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_library.System.Assist;


namespace DAOLibrary.Mapping.Fest.Assist
{
    public class AssistChorifestMap: ClassMap<AssistChoriFest>
    {
		public AssistChorifestMap()
		{
            Table("assist-chorifest");
            Id(x => x.Id)
                .Column("Id")
                .GeneratedBy.Increment();

            References(x => x.Chorifest, "ChorifestId");

            References(x => x.Assist, "AssistId");
            
            References(x => x.AssistMenu, "AssistMenuId");
            Map(x => x.Went)
                .Column("went");
            Map(x => x.Payment)
                .Column("payment");

        }
	}
}
