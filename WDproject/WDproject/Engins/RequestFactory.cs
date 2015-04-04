using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WDproject.Models;

namespace WDproject.Engins
{
    //TODO Create Random Requests
    //Create some random article window, door, etc
    //create request
    //Make random Window request

    class RequestFactory
    {

//window
        private Window NewRandomWindow()
        {
            Random r = new Random();
            const int WindowMinSize = 50;
            const int WindowMaxSize = 300;
            int windowWidth = r.Next(WindowMinSize + 1, WindowMaxSize - 1);
            int windowHeight = r.Next(WindowMinSize + 1, WindowMaxSize - 1);
            return new Window(windowWidth, windowHeight);
        }
//request
        public WindowRequest CreateRandomWindowRequest(uint moment)
        {
            Window window = NewRandomWindow();
         //   Console.WriteLine(window.GetPrice().ToString());
            WindowRequest wr=new WindowRequest(moment, window);
            //Console.WriteLine("IS accepted "+wr.IsAccepted);
            //Console.WriteLine("RequestID: " + wr.RequestID); 
            return wr;
        }
//service
        public Service CreateService(WindowRequest wr)
        {
            double mC = wr.MaterialCost();
            double pC = wr.ProductionCost();
            double iC = wr.InstallationCost();
            mC = mC * wr.Quantity;
            pC = pC * wr.Quantity;
            iC = iC * wr.Quantity;
            Service s = new Service(wr.RequestID, wr.Quantity, mC, iC, pC);
            return s;
        }
        

       


    }
}
