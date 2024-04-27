using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsumer
{
    internal class DeptData
    {

     
        public int dept_Id { get; set; }
        public string dept_Name { get; set; }
        public string dept_Desc { get; set; }
        public string dept_Location { get; set; }
        public string? dept_Manager { get; set; }
        public DateOnly? manager_hiredate { get; set; }
        public int students_Count { get; set; }
    }
}
