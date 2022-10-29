
// 10) Created demo for default and parameterized constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aryan", 22, "Male");
            person.Display();

            Console.ReadKey();
        }
    }

    class Person
    {
        string name;
        int age;
        string gender;
        public string maritnalStatus;



        public Person(string name, int age, string gender) // parameterized constructor
        { 
            this.name = name; 
            this.age = age; 
            this.gender = gender;
            maritnalStatus = "Not Mentioned"; // default constructor 
        }

        public void Display()
        {
            Console.WriteLine(" Hi! My name is " + name + ",\n Age = " + age + ",\n Gender = " + gender + ",\n Maritnal Status = " + maritnalStatus);
        }
    }
}
