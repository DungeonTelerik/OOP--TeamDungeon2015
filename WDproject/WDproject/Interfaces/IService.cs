using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Interfaces
{
    public interface IService:IRequest
    {
        int SericeID { get; set; }//този номер е равен на съответния RequestID
        int BeginMoment { get; set; }
        int CurrentMoment { get; set; }
        int TimeToMake { get; set; } 
        int TimeToInstall { get; set; }
        IWorker Producer { get; set; }
        void Make();//създава се продукта, отчита се разход за труд и материал
        IWorker Installer { get; set; }//извършва се инсталацията, отчита се разход за инсталиране
        double MaterialPrice { get; set; }
        double InstallPrice { get; set; }
        void Install();
        bool IsReady { get; set; }
        bool IsPerformedNow { get; set; }//Извършва се в момента и за виси от CurrentMoment  и BeginMoment
        
    }
}
