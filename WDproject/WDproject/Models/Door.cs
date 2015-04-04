

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
        protected const double InstalationPriceCost = 120.0;
        protected const double ProductionPriceCost = 160.0;
        protected double productionPrice;
        protected double installationPrice;
        protected double materialPrice;
        //constructor
        public Door(sbyte numberOfWings)
        {
            this.NumberOfWings = numberOfWings;
            this.productionPrice = ProductionPriceCost * numberOfWings;
            this.installationPrice = InstalationPriceCost;
            this.materialPrice = this.productionPrice;
            
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

        public double ProductionPrice
        {
            get
            {
                return this.installationPrice;
            }
            set
            {
                this.installationPrice = value; ;
            }
        }

        public double InstallationPrice
        {
            get
            {
                return this.productionPrice;
            }
            set
            {
                this.productionPrice = value;
            }
        }
        public double MaterialPrice
        {
            get
            {
                return this.materialPrice;
            }
        }
        public double GetArea()
        {
            return this.numberOfWings * doorWidth * doorHeight;
        }
        public double GetPrice()
        {
            return this.installationPrice+this.productionPrice+ this.materialPrice;
        }
    }
}
