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
        uint RequestID { get; } //сетва се еднократно с конструктора
        uint Moment { get; set; }      
        int Quantity { get;} //сетва се еднократно с конструктора
      //  bool IsAccepted { get; set; } // при създаване се сетва на лъжа
        double MaterialCost(); //платени разходи за материали
        double ProductionCost(); // платени разходи за производство
        double InstallationCost(); // платени разходи за инсталиране
    }
}
