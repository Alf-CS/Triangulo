using System;
 
class Triangulo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("App Triangulo - 18A");
        Console.WriteLine("Introduzca un lado");
        double lado1, lado2, lado3;
        string ladoMayor;
        lado1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo lado");
        lado2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el último lado");
        lado3 = Double.Parse(Console.ReadLine());
        if ((lado1==lado2) & (lado1==lado3)) Console.WriteLine("El triangulo es EQUILATERO");
        if (lado1 < lado2) {
            if (lado3 < lado2) Console.WriteLine("El lado 2 es el lado mayor");
            else Console.WriteLine("El lado 3 es el lado mayor"); }
        else {
            if (lado3 < lado1) Console.WriteLine("El lado 1 es el lado mayor");
            else Console.WriteLine("El lado 3 es el lado mayor");
        }
    }

}
