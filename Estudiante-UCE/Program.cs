
using System.ComponentModel;

Console.WriteLine("Registro de Calificaciones");


Console.Write("Ingrese el nombre del estudiante: ");
string nombreEstudiante = Console.ReadLine();

List<int> Calificaciones = new List<int>();



for (int i = 1; i <= 4; i++)
{
    Console.Write($"Ingrese la calificación: ");
    int calificacion = int.Parse(Console.ReadLine());
    Calificaciones.Add(calificacion);
}

Console.WriteLine();
Console.WriteLine($"Estudiante: {nombreEstudiante}");
Console.WriteLine("Calificaciones:");





// Mostrar listado de calificaciones

foreach (int c in Calificaciones)
{
    Console.WriteLine($" {c}");
}




//Calcular y mostrar el promedio

int suma = 0;
foreach (int c in Calificaciones)
{
    suma += c;
}


int promedio = suma / Calificaciones.Count;

Console.WriteLine();
Console.WriteLine($"El promedio de sus calificaciones es: {promedio}");
        





