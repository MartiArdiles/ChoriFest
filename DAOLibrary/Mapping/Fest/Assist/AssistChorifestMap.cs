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

            Map(x => x.ChorifestList)
                .Column("ChorifestId");
            //References(x => x.ChorifestList, "ChorifestId");

            Map(x => x.AssistList)
                .Column("AssistId");
            References(x => x.AssistList, "AssistId");
            Map(x => x.IdAssistMenu)
                .Column("AssistMenuId");
            References(x => x.IdAssistMenu, "AssistMenuId");
            Map(x => x.Went)
                .Column("went");
            Map(x => x.Payment)
                .Column("payment");

        }
	}
}
