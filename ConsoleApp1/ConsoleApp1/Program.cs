using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bus myBus = new bus();
            myBus.init();
            myBus.print();
        }
    }
    class bus
    {
        public string name;
        public int capacity;
        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(capacity);
        }
        public void init()
        {
            name = Console.ReadLine();
            capacity = Convert.ToInt16(Console.ReadLine());

        }
    }
}
