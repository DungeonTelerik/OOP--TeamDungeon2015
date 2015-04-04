using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Interfaces;

namespace WDproject.Models
{
    public abstract class Request : WDproject.Interfaces.IRequest
    {
        protected uint requestID;
        protected uint moment;
        protected int quantity;
        protected bool isAccepted;

        Random r= new Random();

        public Request( uint moment)
        {            
            this.moment = moment;
            this.requestID = moment;
            this.quantity = r.Next(1,5);
        }
  //requestID in the first moment is equal of moment, later:  moment-requestID = lag      
        
        public uint RequestID
        {
            get { return this.requestID; }
        }

        public uint Moment
        {
            get
            {
                return this.moment;
            }
            set
            {
                this.moment = value;
            }
        }

        public int Quantity
        {
            get { return this.quantity; }
        }

        public bool IsAccepted
        {
            get
            {
                return this.isAccepted;
            }
            set
            {
                this.isAccepted = value;
            }
        }
        public virtual double MaterialCost() { return 0; }

        public virtual double ProductionCost() { return 0; }

        public virtual double InstallationCost() { return 0; }
        


        public override string ToString()
        {
            return string.Format("ID:{0}, Moment:{1}, Qty:{2}", this.requestID, this.moment, this.quantity);
        }
    }
}
