using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and
            //populate it with data.Then, write a C# program to display the details of all the persons in the array.

            //int size = 3;
            //Person person1 = new Person(size);

            //person1.addPerson(0, "Ahmed", 20);
            //person1.addPerson(1, "Ali", 50);
            //person1.addPerson(2, "Mohamed",30);

            //for (int i = 0; i < person1.Size; i++) {
            //    Console.WriteLine(person1[i]);
            //}
            #endregion

            #region Question 2
            //2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points
            //as input from the user and calculates the distance between them.



            //bool isParsed;
            //int x1, y1, x2, y2;
            //do
            //{
            //    Console.WriteLine("First Point:");
            //    Console.WriteLine("Enter value of x1: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out x1);
            //}
            //while (!isParsed);

            //do
            //{

            //    Console.WriteLine("Enter value of y1: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out y1);
            //}
            //while (!isParsed);

            //do
            //{
            //    Console.WriteLine("Second Point:");
            //    Console.WriteLine("Enter value of x2: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out x2);
            //}
            //while (!isParsed);

            //do
            //{

            //    Console.WriteLine("Enter value of y2: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out y2);
            //}
            //while (!isParsed);

            //Point point1 = new Point(x1,y1);
            //Point point2 = new Point(x2,y2);

            //Console.WriteLine($"Distance between 2 points is {point1.getDistance(point2)}");

            #endregion

            #region Question 3
            //3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons
            //as input from the user and displays the name and age of the oldest person.

            //string? name;
            //bool isParsed;
            //int age;
            //Person person1 = new Person(3);
            //for (int i = 0; i < 3; i++) { 
            //    Console.WriteLine($"Details of person {i + 1}");
            //    do {
            //        Console.Write("Enter Name: ");
            //        name = Console.ReadLine();
            //    }
            //    while (string.IsNullOrEmpty(name));
            //    //do
            //    //{
            //    //    Console.WriteLine("Enter Age: ");
            //    //    isParsed = int.TryParse(Console.ReadLine(), out age);
            //    //}
            //    //while (!isParsed && age <= 0);

            //    while (true)
            //    {
            //        Console.Write("Enter Age: ");
            //        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //        {
            //            break;
            //        }
            //    }
            //    person1.addPerson(i,name,age);
            //}

            //Console.WriteLine(person1.getOlderAge());




            #endregion

            #region Question 4
            Rectangle rectangle= new Rectangle(2,5);
            Console.WriteLine(rectangle.DisplayInfo());

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("After change value of width: ");
            Console.WriteLine("try negative value");
            rectangle.Width = -10;
            Console.WriteLine(rectangle.DisplayInfo());
            Console.WriteLine("try Positive value");
            rectangle.Width = 10;
            Console.WriteLine(rectangle.DisplayInfo());
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("After change value of height: ");
            Console.WriteLine("try negative value");
            rectangle.Height = -10;
            Console.WriteLine(rectangle.DisplayInfo());
            Console.WriteLine("try Positive value");
            rectangle.Height = 10;
            Console.WriteLine(rectangle.DisplayInfo());
            #endregion
        }
    }
}
