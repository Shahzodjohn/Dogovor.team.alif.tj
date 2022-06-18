using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class NonresidentalLeaseDTO
    {
        public int OrderId { get; set; }
        public string DucumentNumber { get; set; }
        public int PremisesOwnerId { get; set; }
        public bool Individual { get; set; }
        public int IndividualId { get; set; }
        public bool LegalEntity { get; set; }
        public int LegalEntityId { get; set; }
        public bool IndividualEnterpreneur { get; set; }
        public int IndividualEnterpreneurId { get; set; }
    }
}
