using Commons.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Commons.Models
{
    public class UserTask
    {
        public string Header { get; set; }
        public Priority Priority { get; set; }
        public string Description { get; set; }
        public User? Assignee { get; set; }
        public List<User>? Users { get; set; } = new List<User>();
        public DateTime DateTime { get; set; }
    }
}
