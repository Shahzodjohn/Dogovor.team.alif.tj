using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RoomInfo
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string OwningReason { get; set; }
        public DateTime ContractDeadline { get; set; }
        public string Quadrature { get; set; }
        public DateTime DocumentDate { get; set; }
    }
}
