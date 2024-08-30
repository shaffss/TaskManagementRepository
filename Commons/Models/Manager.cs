using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Models
{
    public class Manager : User
    {
        public List<Employee> Employees { get; set; }
        public List<UserTask> GetEmployeesTasks()
        {
            return new List<UserTask>();
        }
        public List<Tuple<UserTask,int>> GetAllEmployeesTasksGrouppedByMonths()
        {
            return new List<Tuple<UserTask, int>>();
        }
    }
}
