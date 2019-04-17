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
            Console.WriteLine("****Welcome to MyTypeViewer****");
            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.WriteLine("or enteer Q to quit: ");
                typeName = Console.ReadLine();
                if(typeName.ToUpper()=="Q")
                {
                    break;
                }
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine(" ");
                    MyTypeRel.ListVariousStats(t);
                    MyTypeRel.ListFields(t);
                    MyTypeRel.ListProps(t);
                    MyTypeRel.ListMethods(t);
                    MyTypeRel.ListInterfaces(t);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, can`t find type");
                }
            } while (true);
        }
    }
}
