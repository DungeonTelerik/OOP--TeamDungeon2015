
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;

    public class Window : IWindow
    {
        protected const int WindowMinSize = 50;
        protected const int WindowMaxSize = 300;
        protected const double InstalationPriceConst = 120.0;
        protected const double ProductionPriceConst = 100.0;
        protected const int MaxNumberOfWings = 5;

        private int width;
        private int height;
        private int wingNumbers = 2;
        private double installationPrice;
        private double productionPrice;
        private double materialPrice;


        public Window(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.InstallationPrice = InstalationPriceConst;
            this.ProductionPrice = productionPrice;
            this.MaterialPrice = materialPrice;


        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < WindowMinSize || value > WindowMaxSize)
                {
                    throw new ArgumentOutOfRangeException("value have to be between " + WindowMinSize + " and " + WindowMaxSize + " [cm]");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < WindowMinSize || value > WindowMaxSize)
                {
                    throw new ArgumentOutOfRangeException("value have to be between " + WindowMinSize + " and " + WindowMaxSize + " [cm]");
                }
                this.height = value;

            }
        }

        private void IsInRange(int value)
        {
            if (value >= WindowMinSize && value <= WindowMaxSize)
            {
                this.width = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("value have to be between " + WindowMinSize + " and " + WindowMaxSize + " [cm]");
            }
        }


        public int WingNumbers
        {
            get
            {
                return this.wingNumbers;
            }
            set
            {
                if (value < 0 || value > MaxNumberOfWings)
                {
                    throw new ArgumentOutOfRangeException("Wing numbers must be between 1 and " + MaxNumberOfWings);
                }
                this.wingNumbers = value;
            }
        }

        public string Name { get; set; }

        public Cross CrossType { get; set; }

        public double ProductionPrice
        {
            get
            {
                return this.Width * this.Height * this.WingNumbers / 100;
            }
            set
            {
                this.productionPrice = value; ;
            }
        }

        public double InstallationPrice
        {
            get
            {
                return this.installationPrice;
            }
            set
            {
                this.installationPrice = value;
            }
        }
        public double MaterialPrice
        {
            get
            {
                return this.materialPrice;
            }
            private set
            {
                this.materialPrice = value;
            }
        }
        public double GetArea()
        {
            return this.Width * this.Height;
        }

        public static int MinSize()
        {
            return WindowMinSize;
        }
        public static int MaxSize()
        {
            return WindowMaxSize;
        }
        public override string ToString()
        {
            return string.Format("W x H = {0} x {1}", this.Width, this.Height);
            //TODO possible extension with more window properties
        }
        public virtual double GetPrice()
        {
            return this.InstallationPrice + this.ProductionPrice + this.MaterialPrice;
        }
    }
}
