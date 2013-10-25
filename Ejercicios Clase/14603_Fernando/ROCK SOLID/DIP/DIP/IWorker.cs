using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    interface IWorker
    {
        public void work();
    }

    class Worker : IWorker
    {
        public void work()
        {
            Console.WriteLine("I'm working, yo");
        }
    }

    class SuperWorker : IWorker
    {
        public void work()
        {
            Console.WriteLine("I'm super working, yo");
        }
    }

    class Manager
    {
        IWorker worker;

        public void setWorker(IWorker w)
        {
            worker = w;
        }

        public void manage()
        {
            worker.work();
        }

    }


}
