public class TermometroLimite : Termometro
{
    private double limiteSuperior;
    private bool disparadoEventoLimiteSuperior;
    public delegate void MeuDelegate(string msg, double temp);
    public event MeuDelegate LimiteSuperiorEvent;
    public event MeuDelegate TemperaturaBaixouEvent;
    public TermometroLimite(double ls) 
    {
        limiteSuperior = ls;
        disparadoEventoLimiteSuperior = false;
    }
    public double LimiteSuperior
    {
        get => limiteSuperior;
        set => limiteSuperior = value;
    }

    private void OnLimiteSuperiorEvent()
    {
        if((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
        {
            if(LimiteSuperiorEvent != null)
            {
                LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!", this.Temperatura);
                disparadoEventoLimiteSuperior = true;
            }
        }
    }

    private void OnTemperaturaBaixouEvent()
    {
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior)){

            if(TemperaturaBaixouEvent != null)
            {
                TemperaturaBaixouEvent("Atenção: temperatura normalizou!", this.Temperatura);
                disparadoEventoLimiteSuperior = false;
            }

        }
    }

    public override void Aumentar()
    {
        base.Aumentar();
        OnLimiteSuperiorEvent();
    }

    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        OnLimiteSuperiorEvent();
    }

    public override void Diminuir()
    {
        base.Diminuir();
        OnTemperaturaBaixouEvent();
    }
    public override void Diminuir(double quantia)
    {
        base.Diminuir(quantia);
        OnTemperaturaBaixouEvent();

    }
}
