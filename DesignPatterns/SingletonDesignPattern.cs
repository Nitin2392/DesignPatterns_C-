using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //In this program, we try to explore the implementation of Singleton Design Pattern
    public sealed class SingletonDesignPattern
    {
        int counter = 0;
        private static SingletonDesignPattern checkNullInstance = null; 
       //This attribute is required to ensure only one instance is created

        public static SingletonDesignPattern generateObjectReferenceProperty
        {
            get
            {
                return new SingletonDesignPattern(); //We will be using this property to instantiate the class
            }
        }
        private SingletonDesignPattern() //Changing the constructor to singleton ensures objects cannot be created
        {
            counter--; //The counter value is used to check how many times the object is created
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintHello(string name, char gender) //The function prints the name of the person with a Mr/Ms based on gender
        {
            if (gender == 'M')
            {
                Console.WriteLine("Hello Mr." + name);
            }
            else
            {
                Console.WriteLine("Hello Ms." + name);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            SingletonDesignPattern obj1 = new SingletonDesignPattern(); //Creating Object 1
            SingletonDesignPattern obj2 = new SingletonDesignPattern(); //Creating Object 2
            obj1.PrintHello("Prakash", 'M');  //Calling the PrintHello method using obj1 by passing arguments
            obj2.PrintHello("Rob Rokey", 'M'); //Calling the PrintHello method using obj2 by passing arguments
        }
    }
}
