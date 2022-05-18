public class Termometro
{
    private double valor;
    public Termometro()
    {
        valor = 0.0;
    }
    public double Temperatura
    {
        get => valor;
        set => valor = value;
    }
    virtual public void Aumentar()
    {
        valor += 0.1;
    }
    virtual public void Aumentar(double quantia)
    {
        valor += quantia;
    }
    virtual public void Diminuir()
    {
        valor -= 0.1;
    }
    virtual public void Diminuir(double quantia)
    {
        valor -= quantia;
    }

    public override string ToString()
    {
        return valor.ToString();
    }
}