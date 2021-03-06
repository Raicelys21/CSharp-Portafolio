/* MULTICALCULATOR
  
  "<------------------ MENU OF EXERCISES ------------------>"
  "1. Sum of two number        ~    5. Celsius to fahrenheit"
  "2. Square of a number       ~    6. Area of triangle"
  "3. Area of a circle         ~    7. Volumen and area of cylinder"
  "4. Hypotenuse               ~    8. Area of a circular segment"
  "<-------------------------------------------------------->"
*/


using System;

namespace Multicalculator
{
    class Program
    {
        private static void Exer1()
        {
            Console.Write("Insert the first number; ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second number; ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("The sum is " + sum + ". \n");
        }
        private static void Exer2()
        {
            Console.Write("Insert the number; ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double square = num1 * num1;
            Console.WriteLine("The square of the number is " + square + ". \n");
        }

        private static void Exer3()
        {
            Console.Write("Insert the number; ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double square = num1 * num1;
            double radio = 3.14 * square;
            Console.WriteLine("The area of a circle is " + radio + ". \n");
        }

        private static void Exer4()
        {
            Console.Write("Insert the first hick; ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second hick; ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double square1 = num1 * num1;
            double square2 = num2 * num2;
            double form = Math.Sqrt(square1 + square2);
            Console.WriteLine("The hypotenuse is " + form + ". \n");
        }

        private static void Exer5()
        {
            Console.Write("Insert the grade in Celcius: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double F = (num1 * 1.8) + 31;
            Console.WriteLine("The grade in Fahrenheit is " + F + ". \n");
        }

        private static void Exer6()
        {
            Console.Write("Insert the base: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the height: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double form = (num1 + num2) / 2;
            Console.WriteLine("The area of triangle is " + form + ". \n");
        }

        private static void Exer7()
        {
            Console.Write("Insert the radio: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the height: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * Math.Pow(num1, 2) * num2;
            double vol1 = 6.28 * num1 * num2;
            double vol2 = 6.28 * Math.Sqrt(num1);
            double volf = vol1 + vol2;
            Console.WriteLine("The volumen is " + volf + " and area is " + area + ". \n");
        }

        private static void Exer8()
        {
            Console.Write("Insert the radio: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the angle in grade: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double area1 = (num2 * 6.28) / 360;
            double area2 = (area1 - Math.Sin(num2)) * Math.Sqrt(num1);
            double area = (area2) / 2;
            Console.WriteLine("The area of a circular segment is " + area + ". \n");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("<------------------ MENU OF EXERCISES ------------------>");
            Console.WriteLine("1. Sum of two number        ~    5. Celsius to fahrenheit");
            Console.WriteLine("2. Square of a number       ~    6. Area of triangle");
            Console.WriteLine("3. Area of a circle         ~    7. Volumen and area of cylinder");
            Console.WriteLine("4. Hypotenuse               ~    8. Area of a circular segment");
            Console.WriteLine("<--------------------------------------------------------> \n");

            int menuNumb = 0;
            do
            {
                Console.Write("\n Select a number: ");
                menuNumb = Convert.ToInt32(Console.ReadLine());
                Console.Write(" ");

                switch (menuNumb)
                {
                    case 1:
                        Console.WriteLine("1. Sum of two number");
                        Exer1();
                        break;

                    case 2:
                        Console.WriteLine("2. Square of a number");
                        Exer2();
                        break;

                    case 3:
                        Console.WriteLine("3. Area of a circle");
                        Exer3();
                        break;

                    case 4:
                        Console.WriteLine("4. Hypotenuse");
                        Exer4();
                        break;

                    case 5:
                        Console.WriteLine("5. Celsius to fahrenheit");
                        Exer5();
                        break;

                    case 6:
                        Console.WriteLine("6. Area of triangle");
                        Exer6();
                        break;

                    case 7:
                        Console.WriteLine("7. Volumen and area of cylinder");
                        Exer7();
                        break;

                    case 8:
                        Console.WriteLine("8. Area of a circular segment");
                        Exer8();
                        break;

                    default:
                        Console.WriteLine("Error, try again.");
                        break;
                }
            } while (menuNumb != 0);
        }
    }
}

