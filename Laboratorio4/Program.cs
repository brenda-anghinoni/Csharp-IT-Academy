
//----- Exercício 1
Console.WriteLine("--- Ex.1");
ContaCorrente conta1 = new ContaCorrente("Jane Doe",1000);
Console.WriteLine("Titular: "+conta1.NomeTitular);
Console.WriteLine("Saldo: R$"+conta1.Saldo);
Console.WriteLine("Data de criação: "+conta1.DataCriacao);


//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
Console.WriteLine("Saldo: R$"+conta1.Saldo);
Console.WriteLine("Saldo Médio: R$"+conta1.SaldoMedio);

conta1.Depositar(100);
conta1.Sacar(20);

Console.WriteLine("Saldo: R$"+conta1.Saldo);
Console.WriteLine("Saldo Médio: R$"+conta1.SaldoMedio);


//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
ContaCorrente conta2 = new ContaCorrente("John Doe",500);
Console.WriteLine("Saldo: R$"+conta2.Saldo);
Console.WriteLine("Saldo Médio: R$"+conta2.SaldoMedio);

conta2.Depositar(250);
conta2.Depositar(100);
conta2.Sacar(50);
conta2.Depositar(95.50m);
conta2.Sacar(90);

Console.WriteLine("Saldo: R$"+conta2.Saldo);

