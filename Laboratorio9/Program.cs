TermometroLimite term = new TermometroLimite(5);
Console.WriteLine(term.ToString());

term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataEventoTemperatura);
term.TemperaturaBaixouEvent += new TermometroLimite.MeuDelegate(TrataEventoTemperatura);

term.Aumentar(7);
Console.WriteLine(term.ToString());
term.Diminuir(1);
Console.WriteLine(term.ToString());
term.Diminuir(6);
Console.WriteLine(term.ToString());

static void TrataEventoTemperatura(string msg, double temperatura)
{
    Console.WriteLine(msg+"\nTemperatura: "+temperatura);
}