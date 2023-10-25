// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Clases;

try
{
    //declaracion de variables
    int day, month, year;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());
    //inicializacion de la clase date
    Date dateObject = new Date(day,month,year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());
}
catch (Exception ex)  
{
    Console.WriteLine(ex.Message);
}
