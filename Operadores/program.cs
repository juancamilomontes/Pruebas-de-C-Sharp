namespace Operadores;

class Program
{
    static void Main(string[] args)
    {
        
        int width = 7;
        int height = 5;

        
        int area = width * height;

        
        int perimeter = 2 * width + 2 * height;

        
        width += 3;

        height -= 2;

        
        area = width * height;
        perimeter = 2 * width + 2 * height;

        string mensaje = $"Después de modificar las dimensiones, el área es {area} y el perímetro es {perimeter}, ademas la altura es {height}  y el ancho es {width}.";

        Console.WriteLine(mensaje);
        }
}
