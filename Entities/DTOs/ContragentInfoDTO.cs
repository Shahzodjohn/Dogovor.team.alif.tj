using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ContragentInfoDTO
    {
        public int OrderId { get; set; }
        public string FullName { get; set; }
        public int PassportId { get; set; }
        public string AuthorityIssuingName { get; set; }
        public int CitizenshipId { get; set; }
        public string PassportNumber { get; set; }
        public DateTime DateofRelease { get; set; }
    }
}
