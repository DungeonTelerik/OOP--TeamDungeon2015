using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Models
{
    interface IShelter : IPanel
    {
        double TransportationPrice { get; set; }
    }
}
