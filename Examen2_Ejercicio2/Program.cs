namespace Examen2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double examen1, examen2, final;

            //Poner las calificaciones
            Console.Write("Ingresa la calificación del examen 1: ");
            if (double.TryParse(Console.ReadLine(), out examen1))
            {
                Console.Write("Ingresa la calificación del examen 2: ");
                if (double.TryParse(Console.ReadLine(), out examen2))
                {
                    // Calcular el promedio
                    final = (examen1 + examen2) / 2.0;

                    
                    double Aprobacion = 5.0;//Valor del promedio

                    // Mostrar el resultado
                    Console.WriteLine($"El promedio de los exámenes es: {final}");

                    if (final >= Aprobacion)
                    {
                        Console.WriteLine("Felicidades Aprobaste el curso.");
                    }
                    else
                    {
                        Console.WriteLine("No pasaste el curso.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa la calificacion valida del examen 2.");
                }
            }
            else
            {
                Console.WriteLine("Ingresa la calificacion valida del examen 1.");
            }
        }
    }
} 
