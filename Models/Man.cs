using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2.Models
{
    internal class Man
    {
        public Man() {
            Console.WriteLine("default constructor");
        }

        public Man(int number1)
        {
            Console.WriteLine("parameterized constructor man"+number1);
        }



        public void Work()
        {
            Console.Write("man work");
        }
        public virtual  void  Play()
        {
            Console.WriteLine("man Play");
        }
    }
}
