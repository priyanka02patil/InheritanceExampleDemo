using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleDemo
{
    internal class Program
    {

        // interchange the values using ref type
        //static void SwapValue(ref int a, ref int b)  // input -> a=10,b=20   output--> a=20, b=10
        //{
        //    int temp;
        //    temp = a; // temp=10
        //    a = b; // a=20
        //    b = temp;// b=10
        //}

        // interchange the values using ref type
        static void SwapValue(ref int a, ref int b)  // input -> a=10,b=20   output--> a=20, b=10
        {
            int temp;
            temp = a; // temp=10
            a = b; // a=20
            b = temp;// b=10
        }
        static void Cacl(int x, int y, out int add, out int multiply)
        {
            add = x + y;
            multiply = x * y;
        }


        static void Main(string[] args)
        {
            // option1
            //Date d1 = new Date(1, "Jan", 2025);

            //Employee emp1 = new Employee("Amol", 45600, d1);
            //emp1.CalculateSalary();
            //Console.WriteLine(emp1);

            // option2

            //Employee emp2 = new Employee("Raj", 34000, new Date(1, "Nov", 2024));
            //emp2.CalculateSalary();
            //Console.WriteLine(emp2);


            //SalesManager sm1 = new SalesManager("Rohan", 34000, d1, 5000, 6700);
            //sm1.CalculateSalary();
            //Console.WriteLine(sm1);// want to print sm1 object information -> ToString()

            //Employee emp3 = new SalesManager("Suraj", 33000, d1, 4500, 5500);
            //emp3.CalculateSalary(); // compile time , it call Employee method
            //// late binding , runtime polymorphism / dynamic binding
            //Console.WriteLine(emp3);

            //Employee emp4 = new CEO("priyanka", 45000, d1, "ICICI Project", 6700);
            //emp4.CalculateSalary();

            //Console.WriteLine(emp4);


            //Calc c1 = new Calc();
            //Console.WriteLine(c1.Add(12,34));
            //Console.WriteLine(c1.Multiply(10,34));
            //c1.Invoke(33, 11);

            //Emp e1 = new Emp(201, "Priyanka", Department.Dev, Roles.Emp);
            //Console.WriteLine(e1);

            //Dept d1 = new Dept(1, "HR");
            //Console.WriteLine(d1.Print());


            //var d2 = new Dept(2, "Sales");
            //Console.WriteLine(d2.Print());

            //CoordinatesDemo c1 = new CoordinatesDemo(1, 2);
            //c1.Print();

            //int a = 10, b = 20;
            //Console.WriteLine($"Before swap a={a} , b={b}");
            //SwapValue(ref a, ref b);
            //Console.WriteLine($"After swap a={a} , b={b}");

            //int a = 10, b = 20;
            //Console.WriteLine($"Before swap a={a} , b={b}");
            //SwapValue(ref a, ref b);
            //Console.WriteLine($"After swap a={a} , b={b}");

            // ref variable can not be empty
            // out variable can be empty
            // int x = 5, y = 7, add, mul; // add & mul are the empty variables
            //Cacl(x, y, out add, out mul);
            //Console.WriteLine("add " + add);
            //Console.WriteLine("multiply " + mul);

            
                Calculation c1 = new Calculation();
                Console.WriteLine(c1.Muliply(2, 4));
                Console.WriteLine(c1.Add(44, 66));
            



        }
    }
}
