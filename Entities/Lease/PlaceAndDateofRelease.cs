using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PlaceAndDateofRelease
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public int CityId { get; set; }
        public DateTime DateOfRelease { get; set; }

        public virtual City City { get; set; }
    }
}
