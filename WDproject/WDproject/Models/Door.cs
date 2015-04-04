

namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;

    class Door : IDoor
    {
        //fields
        private const int doorWidth = 80;
        private const int doorHeight = 200;        
        private sbyte numberOfWings = 1;
        protected const double InstalationPrice = 12.0;
        protected const double ProductionPrice = 10.0;
        //constructor
        public Door(sbyte numberOfWings)
        {
            this.NumberOfWings = numberOfWings;
        }

        public sbyte NumberOfWings
        {
            get { return this.numberOfWings; }
            set
            {
                if (value < 0 && value > 2)
                {
                    this.numberOfWings = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter value 1 or 2");
                }
            }
        }

        public string LockingSystem
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

        string IDoor.LockingSystem
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

        string IArticle.Name
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

       

        Cross IArticle.CrossType
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

        int IArticle.ProductionDuration
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

        int IArticle.InstallDuration
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
            return this.numberOfWings * doorWidth * doorHeight;
        }
        public double GetPrice()
        {
            return numberOfWings*(doorWidth*doorHeight)/1000+InstalationPrice+ProductionPrice;
        }
    }
}
