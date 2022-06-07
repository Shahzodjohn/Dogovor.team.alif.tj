using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class RentalPaymentDTO
    {
        public int PathId { get; set; }
        public bool AreTaxesIncluded { get; set; }
        public int? RentalPrice { get; set; }
        public int PaymentWayId { get; set; }
        public bool PrePayment { get; set; }
        public DateTime? PrePaymentDeadline { get; set; }
        public bool MonthlyPayment { get; set; }
        public DateTime? MonthlyPaymentDeadline { get; set; }
    }
}
