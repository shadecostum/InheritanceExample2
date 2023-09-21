using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2.Models
{
    internal class Boy : Man
    {
        public Boy() {
            Console.WriteLine("defaut constructor of boy");
        }
        public Boy(int id) {
            Console.WriteLine("parameterized constructor boy"+id);
        }
        public override void Play() {
            Console.Write("boy plays\n");
        }
        
        public void Eat() {
            Console.WriteLine("boy eat\n");
        }
    }
}
