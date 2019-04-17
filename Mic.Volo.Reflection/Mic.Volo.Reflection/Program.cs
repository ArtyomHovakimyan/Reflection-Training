using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        static void ListMethods(Type t)
        {
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("->{0}",m.Name);
            }
            Console.WriteLine();
        }
    }
}
