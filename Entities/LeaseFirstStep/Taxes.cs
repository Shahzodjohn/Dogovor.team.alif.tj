using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Taxes
    {
        public int Id { get; set; }
        public bool BankWithholdTaxes { get; set; }
        public bool OwnerPaysTaxes { get; set; }

    }
}
