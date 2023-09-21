using InheritanceExample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            man.Play();
            man.Work();
            Console.WriteLine("------------------------------------");
            Boy boy = new Boy();
            boy.Play();
            boy.Eat();
            boy.Work();
            Console.WriteLine("------------------------------------");
            Toddler toddler = new Toddler();    
            toddler.Play();
            toddler.Sleep();
            toddler.Work();




            Console.WriteLine("--------------second----------------------");
            //can acces method common in both class parent and child
            Man man1 = new Boy();
            man1.Play();
            man1.Work();
           // man1.Eat();
            Console.WriteLine("------------typecast-solution-----------------------");
            Boy b1 = (Boy)man1;
            b1.Play();
            b1.Eat();


            Console.WriteLine("-------------Example 3-----------------------");
            Console.WriteLine("------------Polymorphic method---------------------------------");
            PlayGround(new Man());
            PlayGround(new Boy());
            PlayGround(new Toddler());
           





            Console.WriteLine("--------------Constructor----Calling------------------");
            //default constructor must added parent class  boy child constructor called
            //default parent call and
            //child boy contsructor call
            Man manConstructor = new Man();
            Console.WriteLine("------------------------------------");
            Man manConstructor2 = new Man(10);



            Console.WriteLine("-------------Child Constructor calling-----------------------");
            Boy boyConstructor = new Boy();
            Console.WriteLine("------------------------------------");
            Boy boyConstructor2 = new Boy(40);
            Console.WriteLine("------------------------------------");


        }

        static void  PlayGround(Man obj)//passing parent object we can acces parent method common to derived classes
        {
            //accept parent ,also child used parent method
            obj.Play();
            obj.Work();
           // obj.Eat();
            Console.Write("at the ground");
        }
    }
}
