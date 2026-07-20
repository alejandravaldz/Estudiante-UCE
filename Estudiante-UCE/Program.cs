
using System.ComponentModel;


Console.WriteLine("Registro de Calificaciones");
Console.WriteLine();
Console.Write("Ingrese la cantidad de estudiante: ");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidad; i++)
{
    Console.Write($"Ingrese el nombre del estudiante {i}: ");
    string nombre = Console.ReadLine();

    List<int> calificacion = new List<int>();
    for (int m = 1; m <= 4; m++)
    {
        Console.Write("Ingrese la calificación: ");
        int nota = int.Parse(Console.ReadLine());
        calificacion.Add(nota);
    }

    Console.WriteLine();
    Console.WriteLine($"Estudiante: {nombre}");
    Console.WriteLine("Calificaciones:");
    foreach (int c in calificacion)
    {
        Console.WriteLine($" {c}");
    }

    int suma = 0;
    foreach (int c in calificacion)
    {
        suma += c;
    }
    double promedio = (double)suma / calificacion.Count;


    string statatus;

    if (promedio >= 70)
    {
        statatus = "Aprobado";

    }
    else
    {
        statatus = "Reprobado";

    }

    Console.WriteLine();
    Console.WriteLine($"El promedio de sus calificaciones es: {promedio}");
    Console.WriteLine($"status: {statatus}");
    
}

