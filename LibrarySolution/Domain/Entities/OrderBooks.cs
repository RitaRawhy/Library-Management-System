using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderBooks : BaseEntity
    {
        public int Order_Id { get; set; }
        public int Book_Id { get; set; }
        public int Quantity { get; set; }
    }
}
