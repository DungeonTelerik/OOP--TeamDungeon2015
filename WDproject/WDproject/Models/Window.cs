
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;

    class Window : IWindow
    {
        protected const int WindowMinSize = 50;
        protected const int WindowMaxSize = 300;
        protected const double InstalationPrice = 120.0;
        protected const double ProductionPrice = 100.0;
        protected const int maxNumberOfWings=5;

        private int width;
        private int height;
        private int wingNumbers = 2;


        public Window(int width, int height)
        {
            this.Width = width;
            this.Height = height;

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

                if (value < 0 || value > maxNumberOfWings)
                {
                    throw new ArgumentOutOfRangeException("Wing numbers must be between 1 and " + maxNumberOfWings);
                }
                this.wingNumbers = value;
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }



        public Cross CrossType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ProductionDuration
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int InstallDuration
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public double GetArea()
        {
            return this.width * this.height;
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
            return string.Format("W x H = {0} x {1}", this.width, this.height);
            //TODO possible extension with more window properties
        }
        public double GetPrice()
        {
            return InstalationPrice+ProductionPrice*this.wingNumbers+(this.width * this.height)/100;
        }
    }
}
