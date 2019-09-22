using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("4. Exit");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
<<<<<<< HEAD
=======
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Dzielenie");
>>>>>>> 8f0e7f6... Add div to menu
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("3. cosinengo");
                Console.WriteLine("4. Exit");
                
                if (menuOption==0)
                { break; }
            }
        }
    }
}
