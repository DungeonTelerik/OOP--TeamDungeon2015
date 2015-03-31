

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
        const int Miliseconds=5000;
       
        public static void Run()
        {
            //First of all give name to the company
            Console.WriteLine("Enter Company Name: ");
            Company company = new Company(Console.ReadLine());


            int t = 0;
            while (true)
            {
                Pulse(t);
                t++;
        

            }

        }

        private static void Pulse(int t)
        {
            Thread.Sleep(Miliseconds);
            Console.SetCursorPosition(0, 3);
            Console.Write("Pulse:");
            Console.Write(t.ToString("0000"));
            
        }

        
    }
}
