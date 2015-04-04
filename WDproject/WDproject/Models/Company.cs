
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;
    using WDproject.Models;

    public class Company : ICompany
    {
        private string name;
        private CompanyStatus status;
        private List<IWorker> workers = new List<IWorker>();

        public Company(string name, CompanyStatus status = CompanyStatus.Working)
        {
            this.Name = name;
            this.status = status;
        }


        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The company name can not be blank!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double Capital
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

        public IList<IWorker> Personal
        {
            get
            {
                return this.workers;
            }
            set
            {
                ////////////////////////////////////////////
            }
        }

        public void ConfirmRequest(IRequest request)
        {
            throw new NotImplementedException();
        }

        public void ImplementService(IService service)
        {
            throw new NotImplementedException();
        }
        public CompanyStatus Status
        {
            get
            {
                return this.status;
            }

             set
            {
                this.status = value;
            }
        }
    }
}
