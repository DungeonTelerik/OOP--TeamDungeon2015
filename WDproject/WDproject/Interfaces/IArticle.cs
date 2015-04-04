using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Models;

namespace WDproject.Interfaces
{
    public interface IArticle        
    {
        string Name { get; set; }
        double  GetArea(); 
        Cross CrossType { get; set; }
        double InstallationPrice { get; set; }
        double ProductionPrice { get; set; }
        double MaterialPrice { get; }
        double GetPrice();
    }
}
