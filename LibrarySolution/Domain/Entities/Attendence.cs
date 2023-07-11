using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Attendence : BaseEntity
    {
        public int Emp_Id { get; set; }
        public TimeSpan EmpArrivalTime { get; set; }
        public TimeSpan EmpLeavingTime { get; set; }
        public int Permission { get; set; }
        public DateFormat DayDate { get; set; }
        public byte Month { get; set; }
        public int Id { get; set; }
    }
}
