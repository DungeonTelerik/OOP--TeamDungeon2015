

namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;

    class Door : IDoor, IArticle
    {
        //fields
        private const int DoorWidth = 80;
        private const int DoorHeight = 200;        
        private sbyte numberOfWings = 1;
        protected const double InstalationPriceCost = 120.0;
        protected const double ProductionPriceCost = 160.0;
        protected double productionPrice;
        protected double installationPrice = InstalationPriceCost;
        protected double materialPrice;
        //constructor
        public Door(sbyte numberOfWings)
        {
            this.NumberOfWings = numberOfWings;
            this.ProductionPrice = productionPrice;
            this.InstallationPrice = installationPrice;
            this.MaterialPrice = materialPrice ;
            
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

        public string LockingSystem { get; set; }

        public string Name { get; set; }

        public Cross CrossType { get; set; }

        public double ProductionPrice
        {
            get
            {
                return ProductionPriceCost * this.NumberOfWings;
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
            protected set { this.materialPrice = value; }
        }
        public double GetArea()
        {
            return this.NumberOfWings * DoorWidth * DoorHeight;
        }
        public double GetPrice()
        {
            return this.InstallationPrice+this.ProductionPrice+ this.MaterialPrice;
        }
    }
}
