namespace WDproject.Engins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WDproject.Models;
    using WDproject.Interfaces;

    using System.Threading;

    class Engine
    {
        //TODO create compny
        //TODO start timing
        //TODO start RequestFactory
        //TODO make list with services
        //TODO Prossesing services
        //TODO Calculating results and establishing company status
        const int Miliseconds = 5000;
        static Random r = new Random();
        
        public static void Run()
        {
            Console.SetWindowSize(80, 30);
            //First of all give name to the company
            Console.SetCursorPosition(0, 0);
            Console.Write("Enter Company Name: ");
            Company company = new Company(Console.ReadLine());
            company.Capital = 10000.00;
            company.EmployeeCount = 3;
            Console.WriteLine(string.Format("Begin With Capital: {0}, Employees:{1}, Profit rate:{2}", company.Capital, company.EmployeeCount, company.ProfitRate));
            RequestFactory requestedFactory = new RequestFactory();
         //   string clearRowString = new string(' ', 80);
            //    ConsoleKeyInfo cki;
            uint t = 0;
            while (true)
            {
                Pulse(t);
                t++;
                WindowRequest wr = requestedFactory.CreateRandomWindowRequest(t);
                Console.WriteLine(wr.ToString());
                Service s = requestedFactory.CreateService(wr);
                company.AddService(s);
                company.Moment = t;//set current moment /time/
                company.ResultOfTheDay();
                //Console.SetCursorPosition(0, 10);
                //Console.WriteLine(clearRowString);
                //Console.SetCursorPosition(0, 10);
                Console.WriteLine(company.ToString());
            }

        }

        private static void Pulse(uint t)
        {
            Thread.Sleep(Miliseconds);
            //Console.SetCursorPosition(0, 7);
            //string clearRowString = new string(' ', 80);
         //   Console.SetCursorPosition(0, 7);
            Console.Write(t.ToString("0000"));
            Console.Write(" => ");
        }



    }
}
