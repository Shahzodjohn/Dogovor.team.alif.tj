using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LegalEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int LegalEntityPositionId { get; set; } 
        public string EntityName { get; set; }
        public virtual Position Position { get; set; }
    }
}
