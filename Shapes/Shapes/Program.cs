using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square patrat = new Square();
            Cube cub = new Cube();

            float latura = 5;
            float arie = 250;

            Console.WriteLine("Aria patratului este {0}!", patrat.Area(latura));
            Console.WriteLine("Aria cubului este {0}!", cub.Area(latura));
            Console.WriteLine("Latura patratului este {0}!", patrat.Latura(arie));
            Console.WriteLine("Aria cubului este {0}!", cub.Latura(arie));
        }
    }
}
