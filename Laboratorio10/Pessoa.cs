class Pessoa
{
    private bool casada;
    private string nome;
    private DateTime dataNascimento;

    public bool Casada
    {
        get => casada;
        set => casada = value;
    }
    public string Nome
    {
        get => nome;
        set => nome = value;
    }
    public DateTime DataNascimento
    {
        get => dataNascimento;
        set => dataNascimento = value;
    }

    public override string ToString()
    {
        return $"[Nome={nome}, Casada={casada}, DataNascimento={dataNascimento.ToShortDateString()}]";
    }
}