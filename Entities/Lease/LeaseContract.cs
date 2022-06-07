using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LeaseContract
    {
        public int Id { get; set; }
        public int? PlaceAndDateOfReleaseId { get; set; }
        public int? BankSignatoryDataId { get; set; }
        public int? ContrAgentInfoId { get; set; }

        public virtual PlaceAndDateofRelease PlaceAndDateofRelease { get; set; } 
        public virtual BankSignatoryData BankSignatoryData { get; set; } 
        public virtual ContragentInfo ContragentInfo { get; set; } 
    }
}
