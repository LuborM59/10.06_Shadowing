using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06_Shadowing
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        class Animal
        {
            //public virtual string makeSound()
            public string makeSound()
            {
                return "";
            }
        }

        class Fish : Animal
        {

        }

        class Cat : Animal
        {
            //public override string makeSound()
            new public string makeSound()
            {
                return "Mnau";
            }
        }

        //class PersianCat : Cat
        //{
        //    public override string makeSound()
        //    {
        //        return "Mnau Mnau";
        //    }
        //}

    }
}

