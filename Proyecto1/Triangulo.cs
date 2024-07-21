public class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}