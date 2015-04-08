using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Models
{
    class Panel : IPanel
    {
        protected int height;
        protected int width;
        protected int MinSize = 50;
        protected int MaxSize = 200;

        
        
        public double FramePrice
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

        public double GetArea()
        {
            throw new NotImplementedException();
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

        public double InstallationPrice
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

        public double ProductionPrice
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

        public double MaterialPrice
        {
            get { throw new NotImplementedException(); }
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
