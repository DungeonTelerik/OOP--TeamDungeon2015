
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;

    public  class Worker:IWorker
    {
        //Fields
        private string name;
        private double payPerHour;

        //Constructors
        public Worker(string name)
        {
            this.Name = name;
        }

        public Worker(string name, double payPerHour)
        {
            this.PayPerHour = payPerHour;
        }

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double PayPerHour
        {
            get
            {
                return this.payPerHour;
            }
            set
            {
                this.payPerHour = value;
            }
        }

        public Queue<double> PendingPayment
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

        //
        //Methods
        //
        
    }
}
