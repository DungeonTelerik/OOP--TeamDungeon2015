using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Interfaces;

namespace WDproject.Models
{
    class WindowRequest : Request
    {
        protected Window window;

        public WindowRequest(uint moment, Window window)
            : base(moment)
        {
            this.window = window;
        }

        public override double MaterialCost()
        {
            return window.MaterialPrice;
        }
        public override double ProductionCost()
        {

            return window.ProductionPrice;
        }
        public override  double InstallationCost()
        {
            return window.InstallationPrice;
        }
        public override string ToString()
        {
            return string.Format("Window-{0}, Request-{1}, Price:{2}", this.window.ToString(), base.ToString(), this.window.GetPrice() * this.quantity);
        }

    }
}
