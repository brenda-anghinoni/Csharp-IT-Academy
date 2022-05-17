public class Pessoa : IComparable<Pessoa>
{
    private string meuNome;
    private int minhaIdade;

    public Pessoa(string n, int i)
    {
        meuNome = n;
        minhaIdade = i;
    }

    public string Nome{
        get => meuNome;
    }
    public int Idade
    {
        get => minhaIdade;
        set => minhaIdade = value;
    }

    // public int CompareTo(Pessoa outro)
    // {
    //     if(outro == null) return 1;
    //     return Nome.CompareTo(outro.Nome);
    // }

    public int CompareTo(Pessoa outro)
    {
        if(outro == null) return 1;
        return Idade.CompareTo(outro.Idade);
    }
    
    public static IComparer<Pessoa> ComparadorNome()
    {
        return new ComparadorPorNome();
    }
    private class ComparadorPorNome : IComparer<Pessoa>
    {
        public int Compare(Pessoa? p1, Pessoa? p2)
        {   
            if(p1 == null){
                if (p2 == null) return 0;
                else 
                return -1;
            }
            return p1.Nome.CompareTo(p2.Nome);
        }
    }
    public static IComparer<Pessoa> ComparadorIdade()
    {
        return new ComparadorPorIdade();
    }
    private class ComparadorPorIdade : IComparer<Pessoa>
    {
        public int Compare(Pessoa? p1, Pessoa? p2)
        {   
            if(p1 == null){
                if (p2 == null) return 0;
                else 
                return -1;
            }
            return p1.Idade.CompareTo(p2.Idade);
        }
    }
}