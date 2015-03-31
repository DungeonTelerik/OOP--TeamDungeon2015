
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
        private int width;
        private int height;
        

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
                IsInRange(value);
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                IsInRange(value);
            }
        }

        private void IsInRange(int value)
        {
            if (value < 50 && value > 300)
            {
                this.width = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("value have to be between 50 and 300[cm]");
            }
        }


        public int WingNumbers
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
    }
}
