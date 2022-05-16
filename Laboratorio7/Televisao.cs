public class Televisao : IEstadoBinario
{
    public bool Ligado {get; set;}
    public int Polegadas {get; set;}

    public Televisao(int p)
    {
        Polegadas = p;
    }

    public void Ligar(){
        Ligado = true;
    }
    public void Desligar(){
        Ligado = false;
    }

    public EstadoBinario Estado
    {
        get 
        {
            if(Ligado) return EstadoBinario.Ligado;
            else return EstadoBinario.Desligado;
        }
    }
}