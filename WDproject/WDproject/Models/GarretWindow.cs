using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Interfaces;

namespace WDproject.Models
{
    class GarretWindow : Window, IWindow, IArticle
    {
        protected const double AdditionalInstallationPriceCount = 30.0;
        protected const double AdditionalProductionPriceCount = 30.0;

        private int widthOfSkylight;

        public GarretWindow(int width, int height, int widthOfSkylight)
            : base(width, height)
        {
            this.widthOfSkylight = widthOfSkylight;
            this.InstallationPrice = base.InstallationPrice+AdditionalInstallationPriceCount;
            this.ProductionPrice = base.ProductionPrice + AdditionalProductionPriceCount;
        }

        public int WidthOfSkylight
        {
            get { return this.widthOfSkylight; }
            set
            {
                if (value < WindowMinSize || value > WindowMaxSize)
                {
                    throw new ArgumentOutOfRangeException("Dimensions of window must be between  "+WindowMinSize+" and "+WindowMaxSize);
                }
                this.widthOfSkylight = value;
            }
        }
        public override double GetPrice()
        {
            return this.ProductionPrice + this.InstallationPrice + base.MaterialPrice;
        }



    }
}
