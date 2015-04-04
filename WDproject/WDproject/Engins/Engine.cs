﻿namespace WDproject.Engins
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
            //First of all give name to the company
            Console.SetCursorPosition(10, 0);
            Console.Write("Enter Company Name: ");
            Company company = new Company(Console.ReadLine());
            company.Capital = 10000.00;
            company.EmployeeCount = 3;

            RequestFactory requestedFactory = new RequestFactory();
        //    ConsoleKeyInfo cki;
            uint t = 0;
            while (true)
            {
                Pulse(t);
                t++;
                WindowRequest wr = requestedFactory.CreateRandomWindowRequest(t);
                Console.WriteLine(wr.ToString());
             Service s =requestedFactory.CreateService(wr);
             company.AddService(s);

            }

        }

        private static void Pulse(uint t)
        {
            Thread.Sleep(Miliseconds);
            Console.Write(t.ToString("0000"));
            Console.Write(" => ");
        }



    }
}
