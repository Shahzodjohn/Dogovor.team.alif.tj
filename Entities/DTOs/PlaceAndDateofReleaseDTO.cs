using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class PlaceAndDateofReleaseDTO
    {
        public string DocumentNumber { get; set; }
        public int CityId { get; set; }
        public DateTime DateOfRelease { get; set; }
    }
}
