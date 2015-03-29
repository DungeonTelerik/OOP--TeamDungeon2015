using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Interfaces
{
    public interface IRequest
    {
       //Задава им се стойност еднократно
        int RequestID { get; set; }
        uint Moment { get; set; }
        IArticle article { get; set; }
        int Quantity { get; set; }
        bool IsAccepted { get; set; }


    }
}
