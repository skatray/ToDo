using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }
        public int category_id { get; set; }
    }
}
