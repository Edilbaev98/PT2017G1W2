using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// Complex class example
    /// </summary>
    class Complex
    {
        public int x, y;
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x + "/" + y);
        }

        public override string ToString()
        {
            return x + "/" + y;
        }

        // (1, 2), (2,3) => (3, 5)
        public Complex Add(Complex c) // this -> a, c -> b
        {
            Complex d = new Complex(this.x + c.x, this.y + c.y);
            return d;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x + c2.x, c1.y + c2.y);
            return c;
        }
    }
    /// <summary>
    /// Student class example
    /// </summary>
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public double gpa;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public override string ToString()
        {
            return this.name + ": " + this.surname + ": " + this.age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 3);

            Complex c = a + b + a + b;
            Console.WriteLine(c);
            Console.ReadKey();
            
            /*
            Student a = new Student("Marat", "Abuov");
            Student b = new Student("aaa", "bbb", 20);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
             */ 
        }
    }
}
