public class Program
{
    public static void Main()
    {

        Persona persona = new Persona("Gabriel Perez", 30, "Santo Domingo");
        persona.MostrarInformacion();
        Console.WriteLine($"Edad en años: {persona.CalcularEdadEnAnios()}");

        Estudiante estudiante = new Estudiante("Juana Lopez", 20, "Santiago", "Ingeniería", "2023-1234");
        estudiante.MostrarInformacionCompleta();


        Rectangulo rectangulo = new Rectangulo(5, 10);
        Circulo circulo = new Circulo(7);
        Triangulo triangulo = new Triangulo(6, 8);

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
    }
}
