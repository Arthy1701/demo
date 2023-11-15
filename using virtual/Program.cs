using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demo");
            car c1 = new car();
            c1.Drive();
            
            car c2 = new Electric_car();
            c2.Drive();

            Electric_car c3 = new Electric_car();
            c3.checkbattery();
            car c4 = new petrol();
            c4.Drive();
            petrol c5 = new petrol();
           // Console.WriteLine( c5.GetTankcapacity());
            c5.fuelcheck();
            c5.GetTankcapacity();
        }
    }
}
