public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}