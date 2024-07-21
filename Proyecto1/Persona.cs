using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Ciudad { get; set; }

    public Persona(string nombre, int edad, string ciudad)
    {
        Nombre = nombre;
        Edad = edad;
        Ciudad = ciudad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
    }

    public int CalcularEdadEnAnios()
    {
        return Edad;
    }
}