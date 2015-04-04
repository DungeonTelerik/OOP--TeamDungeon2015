using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDproject.Models
{
    public class Service : IService
    {
        protected uint requestID;
        protected uint momentFromBeginning;
        protected int quantity;
        protected double materialCost;
        protected double installationCost;
        protected double productionCost;
        protected double reportedIncome;
        protected int unfinished;

        public Service(uint requestID, int quantity, double materialCost, double installationCost, double productionCost)
        {
            this.requestID = requestID;
            this.quantity = quantity;
            this.momentFromBeginning = 0;// в началото времето е нула
            this.materialCost = materialCost;
            this.installationCost = installationCost;
            this.productionCost = productionCost;
            this.reportedIncome = 0;// преди да изпълним поръчката, не ни плащат, ако е положително - платено ни е
            this.unfinished = quantity;//в началото всички неща са незавършени

        }
        
        
        public uint RequestID
        {
            get { return this.requestID; }
        }

        public uint MomentFromBegining
        {
            get
            {
                return this.momentFromBeginning;
            }
            set
            {
                this.momentFromBeginning = value;
            }
        }

        public int Quantity
        {
            get { return this.quantity; }
        }

        public double MaterialCost
        {
            get
            {
                return this.materialCost; ;
            }
            set
            {
                this.materialCost = value;
            }
        }

        public double ProductionCost
        {
            get
            {
                return this.productionCost;
            }
            set
            {
                this.productionCost = value;
            }
        }

        public double InstallationCost
        {
            get
            {
                return this.installationCost;
            }
            set
            {
                this.installationCost = value;
            }
        }

        public double ReportedIncome
        {
            get
            {
                return this.reportedIncome;
            }
            set
            {
                this.reportedIncome = value;
            }
        }

        public int Unfinished
        {
            get
            {
                return this.unfinished;
            }
            set
            {
                this.unfinished = value;
            }
        }

        public double GetExpenseValue()
        {
            return (this.InstallationCost + this.MaterialCost + this.ProductionCost) * this.Quantity;
        }
    }
}
