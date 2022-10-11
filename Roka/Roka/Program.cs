using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roka
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Adja meg hogy milyen széles legyen a mező:");
            int mezox = int.Parse(Console.ReadLine());
            Console.Write("Adja meg hogy milyen magas legyen a mező:");
            int mezoy = int.Parse(Console.ReadLine());
            int ossz = mezoy * mezox;
            Console.WriteLine($"Összesen {ossz} mező van");
            Random rnd = new Random();
            int[,] fu= new int[mezox, mezoy];


            Console.ReadKey();
        }
    }
}
