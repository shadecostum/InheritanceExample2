using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2.Models
{
    internal class Toddler: Man
    {
        public  void Play()
        {
            Console.Write("Toddeler plays\n");
        }
        public void Sleep() {
            Console.WriteLine("tottler sleep\n");
        }
    }
}
