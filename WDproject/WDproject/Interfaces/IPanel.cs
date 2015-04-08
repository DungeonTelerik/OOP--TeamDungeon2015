using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Models
{
    interface IPanel : WDproject.Interfaces.IArticle
    {
        double FramePrice { get; set; }
    }
}
