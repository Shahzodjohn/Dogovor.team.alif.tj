using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class AddressesDTO
    {
        public int PathId { get; set; }
        public string HomeAddress { get; set; }
        public string OwnerINN { get; set; }
    }
}
