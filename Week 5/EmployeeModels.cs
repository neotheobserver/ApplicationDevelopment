using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Week_5
{
    class EmployeeModels
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public bool isSupervisor { get; set; } = false;
        public bool isAdmin { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
