using System;
using System.Collections.Generic;
using System.Text.Json;

namespace mvc_project.Models.Common
{
    public class QueryGridModel
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public SearchModel search { get; set; }
        public List<OrderByModel> order { get; set; }
        public List<ColumnModel> columns { get; set; }

        public override string ToString()
        {
            return "\n" + JsonSerializer.Serialize(this) + "\n";
        }
    }

    public enum DirectionModel
    {
        asc,
        desc
    }

    public class OrderByModel
    {
        public int column { get; set; }
        public DirectionModel dir { get; set; }
    }

    public class SearchModel
    {
        public string value { get; set; }
        public string regex { get; set; }
    }

    public class ColumnModel
    {
        public string data { get; set; }
        public string name { get; set; }
        public Boolean sercheable { get; set; }
        public Boolean orderable { get; set; }
        public SearchModel search { get; set; }
    }
}