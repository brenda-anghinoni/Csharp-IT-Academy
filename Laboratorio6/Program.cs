/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");


//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
ContaPoupanca conta1 = new ContaPoupanca(0.7m, new DateTime(2020, 5, 10), "Pam Beesly");
conta1.Depositar(3500);
Console.WriteLine("ID: "+conta1.Id);
Console.WriteLine("Titular: "+conta1.Titular);
Console.WriteLine("Saldo: "+conta1.Saldo);
Console.WriteLine("Data de aniversário de conta: "+conta1.DataAniversario);
Console.WriteLine("Juros: "+conta1.Juros);

ContaPoupanca conta2 = new ContaPoupanca(0.14m, new DateTime(2020, 2, 28), "Jim Halpert");
Console.WriteLine("Titular: "+conta2.Titular);
Console.WriteLine("Saldo: "+conta2.Saldo);
conta2.Depositar(300);
conta2.Depositar(200);
Console.WriteLine("Saldo: "+conta2.Saldo);

ContaPoupanca conta3 = new ContaPoupanca(0.2m, new DateTime(2021, 12, 12), "Dwight Schrute");
Console.WriteLine("Titular: "+conta3.Titular);
conta3.Depositar(2000);
Console.WriteLine("Saldo: "+conta3.Saldo);
conta3.Sacar(1385);
Console.WriteLine("Saldo: "+conta3.Saldo);

ContaPoupanca conta4 = new ContaPoupanca(0.5m, new DateTime(2015, 5, 16), "Michael Scott");
Console.WriteLine("Titular: "+conta4.Titular);
conta4.Depositar(1000);
Console.WriteLine("Saldo: "+conta4.Saldo);
conta4.AdicionarRendimento();
Console.WriteLine("Saldo: "+conta4.Saldo);


//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
List<Conta> contas = new List<Conta>();
contas.Add(conta1);
contas.Add(conta2);
contas.Add(conta3);
contas.Add(conta4);

foreach (var item in contas)
{
    Console.WriteLine(item.Id+" \tSaldo: R$"+item.Saldo);
}