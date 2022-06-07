using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IndividualEnterpreneur
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int LegalEntityPositionId { get; set; }
        public DateTime DateOfRelease { get; set; }
        public virtual Position Position { get; set; }
    }
}
