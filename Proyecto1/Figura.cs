public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double ancho, double altura)
    {
        Ancho = ancho;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Ancho * Altura;
    }
}
