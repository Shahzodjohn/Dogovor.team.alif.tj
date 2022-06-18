using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class TaxesDTO
    {
        public int PathId { get; set; }
        public bool BankWithholdTaxes { get; set; }
        public bool OwnerPaysTaxes { get; set; }
    }
}
