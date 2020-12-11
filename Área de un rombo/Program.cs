using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables 
        double area = 0, bd = 0, hd = 0;

        //Explicacion de la función
        Console.WriteLine("Encontrar el área de un rombo.");
        Console.WriteLine(" ");

        //Pidiendo datos de lados 1
        Console.Write("Ingrese el lado diagonal: ");
        bd = Int32.Parse(Console.ReadLine());

        //Pidiendo datos de lados 2
        Console.Write("Ingrese el lado diagonal: ");
        hd = Int32.Parse(Console.ReadLine());

        //Realiza la operacion
        area = (bd * hd) / 2;

        //Imprimiendo el resultado
        Console.WriteLine(" ");
        Console.WriteLine("El área del rombo es: " + area);
        Console.ReadKey();
    }
}
