//using System;

//namespace TopLevel
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

using System;


inicio();

void inicio() {
Console.Write("Ingrese su nombre: ");
string name = Console.ReadLine();

Console.Write("Ingrese su correo: ");
string correo = Console.ReadLine();

Console.Write("INgrese su edad: ");
int edad = int.Parse(Console.ReadLine());

Validacion(name,correo,edad);

Console.WriteLine(name);
Console.WriteLine(correo);
Console.WriteLine(edad + "Años");
}

void Validacion(string name, string email, int age) 
{
    if (string.IsNullOrEmpty(name)) 
    {
        Console.WriteLine("El nombre no puede estar vacio");
        Console.WriteLine("");
        inicio();
    }
    if (string.IsNullOrEmpty(email)) 
    {
        Console.WriteLine("El correo no puede estar vacio");
        Console.WriteLine("");
        inicio();
    }
    if (age < 0) 
    {
        Console.WriteLine("La edad no puede ser nagativa");
        Console.WriteLine("");
        inicio();
    }
}







