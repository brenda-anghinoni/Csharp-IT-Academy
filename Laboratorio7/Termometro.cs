public class Termometro
{
    private double temperatura;
    public double Temperatura 
    {
        get => temperatura;
    }
    public Termometro()
    {
        temperatura = 0.0;
    }
    public void Aumentar(double t)
    {
        temperatura += t;
    }

    public void Diminuir(double t)
    {
        temperatura -= t;
    }
}