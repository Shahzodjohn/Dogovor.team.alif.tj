using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Individual
    {
        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public DateTime passportDateOfRelease { get; set; }
        public string fullName { get; set; }
        public string PlaceOfRelease { get; set; }
    }
}
