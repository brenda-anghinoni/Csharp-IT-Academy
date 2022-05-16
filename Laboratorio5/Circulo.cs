public class Circulo
{
    private double coordX;
    private double coordY;
    private double raio;

    public Circulo() : this(0, 0, 1)
    {}

    public Circulo(double x, double y, double r)
    {
        coordX = x;
        coordY = y;
        raio = Math.Abs(r);
    }

    public double CentroX
    {
        get => coordX;
        set => coordX = value;
    }

    public double CentroY
    {
        get => coordY;
        set => coordY = value;
    }

    public double Raio
    {
        get => raio;
        set => raio = value;
    }

    public override string ToString()
    {
        return "(" + string.Format("{0:F2}", CentroX) + ";"
                   + string.Format("{0:F2}", CentroY) + ")"
                   + " raio=" + string.Format("{0:F2}", Raio);
    }
}