using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WDproject.Models
{
    public interface IService
    {
        uint RequestID { get; } //сетва се еднократно с конструктора
        uint MomentFromBegining { get; set; } // време от началото на изпълнението
        int Quantity { get; } //сетва се еднократно с конструктора
        double MaterialCost { get; set; } //платени разходи за материали
        double ProductionCost { get; set; } // платени разходи за производство
        double InstallationCost { get; set; } // платени разходи за инсталиране
        double ReportedIncome { get; set; } // реализиран приход след предаване
        int Unfinished { get; set; }//брой артикули, които трябва да се завършат
    }
}
