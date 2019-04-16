using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.Reflection
{
    class SportsCar
    {
        public string Model { get; set; }
        public SportsCar()
        {
            Model = null;
        }
        public SportsCar(string m)
        {
            Model = m;
        }
        public override string ToString()
        {
            return Model;
        }
    }
}
