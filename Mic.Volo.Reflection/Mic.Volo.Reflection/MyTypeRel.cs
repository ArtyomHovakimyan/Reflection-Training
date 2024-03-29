﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.Reflection
{
    class MyTypeRel
    {
        public static void ListMethods(Type t)
        {
            Console.WriteLine("****Methods*****");
            var methodNames = from n in t.GetMethods()
                              select n.Name;
            foreach (var name in methodNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }
        public static void ListFields(Type t)
        {
            Console.WriteLine("****Fields****");
            var fieldNames = from f in t.GetFields()
                             select f.Name;
            foreach (var name in fieldNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }
        public static void ListProps(Type t)
        {
            Console.WriteLine("****Properties****");
            var propNames = from p in t.GetProperties()
                            select p.Name;
            foreach (var name in propNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }
        public static void ListInterfaces(Type t)
        {
            Console.WriteLine("****Interfaces****");
            var ifaces = from i in t.GetInterfaces()
                         select i;
            foreach (Type i in ifaces)
            {
                Console.WriteLine("->{0}", i.Name);
            }
        }
        public static void ListVariousStats(Type t)
        {
            Console.WriteLine("****Various Statistics*****");
            Console.WriteLine("base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed ? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}
