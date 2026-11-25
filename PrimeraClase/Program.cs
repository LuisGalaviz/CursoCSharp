Console.WriteLine("================================");
Console.WriteLine("Welcome to the C# Program!");
Console.WriteLine("================================");

Console.Write("Como te llamas? ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Cuantos años tienes? ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Cuanto ganas al mes? ");
double sueldo = Convert.ToDouble(Console.ReadLine());

double salarioAnual = sueldo * 12;

Console.WriteLine();
Console.WriteLine("Info del usuario:");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Sueldo: {sueldo:C2}");
Console.WriteLine($"Salario anual: {salarioAnual:C2}");
Console.WriteLine("Lenguaje de programación: C#");
