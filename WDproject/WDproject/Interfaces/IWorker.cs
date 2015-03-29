using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Interfaces
{
    public interface IWorker
    {
        string Name { get; set; }
        double PayPerHour { get; set; }
        Queue<double> PendingPayment { get; set; }
    }
}
