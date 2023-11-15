using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_virtual
{
    class petrol : car
    {
        
        public void startEngine()
        {
            Console.WriteLine("Engine started:");
        }
       private double Tankcapacity;
       public petrol()
       {
           Tankcapacity = 10;
       }
        public double GetTankcapacity()
        {

            Tankcapacity = 10;
            Console.WriteLine(Tankcapacity);
        }

        
        //

       public double fuelcheck()
        {
            return Tankcapacity;

        }

       public double Getfuel(double fuelfullfill)
       {

           Tankcapacity = Tankcapacity + fuelfullfill;
           return Tankcapacity;

       }

       public void setfuel(double modelfuel)
       {
           Tankcapacity = modelfuel;
       }


       public void Reducefuel(double Reducefuel)
       {
           if (Tankcapacity >= Reducefuel)
           {
               Tankcapacity = Tankcapacity - Reducefuel;
               Console.WriteLine("Your Reducefuel capacity is :" + Tankcapacity);
           }
           else
           {
               Console.WriteLine("Insufficient fuel : ");
           }

       }
    }

}
    

