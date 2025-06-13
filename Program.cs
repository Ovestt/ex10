using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы угла: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Corner corner = new Corner(gradus, min, sec);
            Console.Write(corner.ToRadius());
            Console.ReadKey();
        }
    }
}
