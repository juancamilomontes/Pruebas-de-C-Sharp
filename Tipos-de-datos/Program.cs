namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int Age = 25;
        decimal height = 1.75m;
        Boolean is_student = true;
        string name = "Ana";
        char grade = 'A';

        string mensaje = $"Hola {name}, en este momento tienes {Age} años y mides {height}, ¿que si ya eres estudiante? {is_student}, y estas en grado {grade}, muchas felicitaciones.";

        Console.WriteLine(mensaje);


    }
}
