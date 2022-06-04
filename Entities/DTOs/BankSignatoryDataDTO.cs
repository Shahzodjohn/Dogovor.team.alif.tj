using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class BankSignatoryDataDTO
    {
        public int OrderId { get; set; }
        public int ContracterId { get; set; }
        public string WorkersFullName { get; set; }
        public int CityzenshipId { get; set; }
        public int PositionId { get; set; }
        public bool attorney { get; set; }
        public bool charter { get; set; }
        public DateTime? DateofRelease { get; set; }
        public string DocumentNumber { get; set; }
    }
}
