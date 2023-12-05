using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setters_Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property p1 = new Property();
            // p1.setId(89);
            //Console.WriteLine( p1.getId());
            int NewId = p1.id ;           //calling the get accesor of property

            Console.WriteLine(NewId);
            p1.id = 90;                 //setting the set accessor of property
            Console.WriteLine(p1.id);

            Console.ReadLine();
        }
    }
}

