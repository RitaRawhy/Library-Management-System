using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Borrow : BaseEntity
    {
        public int Order_Id { get; set; }
        public int Book_Id { get; set; }
        public DateFormat BorrowDate { get; set; }
        public DateFormat ReturnDate { get; set; }
    }
}
