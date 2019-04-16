using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar car = new SportsCar();
            Type t = car.GetType();
            Type t1 = typeof(SportsCar);
            Type t2 = Type.GetType("");
        }
    }
}
