
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Interfaces;
    using WDproject.Models;

    public class Company :  ICompany
    {
        private string name;
        private CompanyStatus status;
        private double capital;
        protected List<IService> services;
        private List<Operation> debit;
        private List<Operation> credit;
        private uint moment;
        private int employeeCount;
        public  double profitRate = 0.15; //норма на печалба
        private const double Salary=75;//заплатата е константа, но може да бъде и друго
       

        public Company(string name, CompanyStatus status = CompanyStatus.Working)
        {
            this.Name = name;
            this.status = status;
            this.services = new List<IService>();
            this.debit = new List<Operation>();
            this.credit = new List<Operation>();
            this.moment = 0;


        }
        public int EmployeeCount
        {
            get
            {
                return this.employeeCount;
            }
            set
            {
                this.employeeCount = value;
            }
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
                return this.capital;
            }
            set
            {
                this.capital = value;
            }
        }

        public double ProfitRate
        {
            get
            {
                return this.profitRate;
            }

    }
        public void AddService(Service s)
        {
            this.services.Add(s);
//с приемането на поръчката се начисляват разходите за материали, производство и инсталиране
            Operation item = new Operation();
            item.moment = s.RequestID;
            item.operationValue = (s.ProductionCost + s.MaterialCost + s.InstallationCost);
            this.credit.Add(item);
         //   Print(this.credit);
        }
       
        public CompanyStatus Status
        {
            get
            {
                return this.status;
            }

            protected  set
            {
                this.status = value;
            }
        }

        public void ResultOfTheDay()
        {
            uint t = this.Moment; 
            FinishCheck();//отчита изпълнението

            var notReportedServises = from item in this.services
                                      where item.ReportedIncome == 0 && item.Unfinished == 0
                                      select item;
            foreach (var item in notReportedServises)
            {
                Operation opr = new Operation();
                
                double price = (item.MaterialCost + item.ProductionCost + item.InstallationCost) ;
                item.ReportedIncome = price;

                opr.moment = t;
                opr.operationValue = price*(1+this.profitRate);
                this.debit.Add(opr);
               
            }
//отчита заплащането
            Operation oprSalary = new Operation();
            oprSalary.moment = this.Moment;
            oprSalary.operationValue = this.employeeCount * Salary;
            this.credit.Add(oprSalary);
// пресмята капитала
            double saldoDebit = SumOperation(this.debit);


            double saldoCredit = SumOperation(this.credit);

          //  Console.WriteLine(string.Format("Saldo Debit: {0:0.00}  Saldo Credit: {1:0.00} ", saldoDebit, saldoCredit));
            double result = this.Capital + saldoDebit - saldoCredit;
            this.Capital = result;
        }

        private void FinishCheck()
        {
            uint t = this.Moment;
            //отчита завършването - един човек може да произведе и монтира един артикул на ден
            var notReadyServices = this.services.FindAll(v => v.Unfinished > 0);
            int personsDay = this.employeeCount;


            foreach (var item in notReadyServices)
            {
                if (personsDay > 0)
                {
                    if (item.Unfinished > personsDay)
                    {
                        item.Unfinished = item.Unfinished - personsDay;
                        personsDay = 0;
                    }
                    else if (item.Unfinished < personsDay)
                    {
                        personsDay = personsDay - item.Unfinished;
                        item.Unfinished = 0;
                    }
                    else
                    {
                        personsDay = 0;
                        item.Unfinished = 0;
                    }
                }
            }
           
        }

        public void Print(List<Operation> list)
        {
            Operation item = new Operation();
            for (int i = 0; i < list.Count; i++)
            {
                item = list[i];
                Console.WriteLine(item.moment + "  =>  "+item.operationValue);
            }

        }

        public double SumOperation(List<Operation> list)
        {
            double sum = 0;
            Operation item = new Operation();
            for (int i = 0; i < list.Count; i++)
            {
                item = list[i];
                sum += item.operationValue;
            }
            return sum;
        }
        public override string ToString()
        {
            return string.Format("Saldo Debit: {0:0.00}  Saldo Credit: {1:0.00}  Capital: {2:0.00} ",
                SumOperation(this.debit), SumOperation(this.credit), this.Capital);
        }
    }
}
