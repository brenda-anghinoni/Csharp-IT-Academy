List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980, 3, 14), Casada = true},
    new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978, 10, 23), Casada = true},
    new Pessoa{Nome="Maria", DataNascimento=new DateTime(2000, 1, 10), Casada = false},
    new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999, 12, 12), Casada = false}
};

var linq1 = from p in pessoas
            where p.Casada && p.DataNascimento >= new DateTime(1980,1,1)
            select p;

foreach(var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980,1,1));
foreach(var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
 Console.WriteLine("\n--- Ex.1");
 var linqEx1 = pessoas.GroupBy(p => p.Casada);

foreach(var grupos in linqEx1)
  {
    if (grupos.Key){
        Console.WriteLine("Pessoas casadas: "+grupos.Count());
    }else{
        Console.WriteLine("Pessoas solteiras: "+grupos.Count());
    }
    foreach (var pessoa in grupos){
        Console.WriteLine(pessoa.Nome);
    }
    Console.WriteLine();
}

//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
var linqEx2 = pessoas.MinBy(p => p.DataNascimento);
Console.WriteLine("Pessoa mais velha: "+linqEx2.Nome+", nascimento: "+linqEx2.DataNascimento.ToShortDateString());

//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
var linqEx3 = pessoas.Where(p => p.Casada == false)
                     .MaxBy(p => p.DataNascimento);

Console.WriteLine("Pessoa mais nova solteira: "+linqEx3.Nome+", nascimento: "+linqEx3.DataNascimento.ToShortDateString());
