using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Commons.Models
{
    public enum Priority
    {
        Critical,
        High,
        Urgent,
        Moderate,
        Normal,
        Low,
        Optional,
        Deferred,
        Backlog,
        Trivial
    }
    public class UserTask
    {
        public string Header { get; set; }
        public Priority Priority { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public List<User> Users { get; set; }
    }
}
