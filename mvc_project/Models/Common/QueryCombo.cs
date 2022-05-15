using System;
using System.Collections.Generic;
using System.Text.Json;

namespace mvc_project.Models.Common
{
    public class ComboQueryModel
    {
        public string query { get; set; }
        
        public override string ToString()
        {
            return "\n" + JsonSerializer.Serialize(this) + "\n";
        }
    }

    public class PaginatedComboQueryModel
    {
        public string query { get; set; }
        
        public int page { get; set; }
        
        public int pageSize { get; set; }
        
        public override string ToString()
        {
            return "\n" + JsonSerializer.Serialize(this) + "\n";
        }
    }
}