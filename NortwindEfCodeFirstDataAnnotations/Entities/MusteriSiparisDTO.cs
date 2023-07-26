using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotations.Entities
{
    [ComplexType]
    internal class MusteriSiparisDTO
    {
        public string CustomerId { get; set; }
        public int OrderID { get; set; }

        //Other
    }
}
