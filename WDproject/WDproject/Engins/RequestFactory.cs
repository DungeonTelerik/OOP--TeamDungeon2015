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
        // опашка на чакащите поръчки
        // опашка на приетите поръчки
        // списък на отказаните поръчки
        public WindowRequest CreateRandomWindowRequest(uint moment)
        {
            Window window = NewRandomWindow();
            return new WindowRequest(moment, window);
        }

        private Window NewRandomWindow()
        {
            Random r = new Random();
            const int WindowMinSize = 50;
            const int WindowMaxSize = 300;
            int windowWidth = r.Next(WindowMinSize + 1, WindowMaxSize - 1);
            int windowHeight = r.Next(WindowMinSize + 1, WindowMaxSize - 1);
            return new Window(windowWidth, windowHeight);
        }


    }
}
