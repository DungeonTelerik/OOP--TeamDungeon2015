

namespace WDproject.Engins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WDproject.Models;
    using WDproject.Interfaces;

    class Engine
    {
        //TODO create compny
        //TODO start timing
        //TODO start RequestFactory
        //TODO make list with services
        //TODO Prossesing services
        //TODO Calculating results and establishing company status

        public static void Run()
        {
            //First of all give name to the company
            Console.WriteLine("Enter Company Name: ");
            Company company = new Company(Console.ReadLine());



            while (true)
            {

            }

        }

        
    }
}
