using System;

class ContaCorrente {

    private decimal saldo;
    private DateTime dataCriacao;
    private string nomeTitular;
    private decimal acumuladorSaldo;
    private decimal contadorOperacoes;

    public ContaCorrente(string titular, decimal val){
        saldo = val;
        dataCriacao = DateTime.Now;
        nomeTitular = titular;
        contadorOperacoes = 1;
        acumuladorSaldo = val;
    }
    
    public decimal Saldo => saldo;
    public DateTime DataCriacao => dataCriacao;
    public string NomeTitular => nomeTitular;
    public decimal SaldoMedio
    {
        get
        {
            decimal saldoMedio = 0;
            if(contadorOperacoes > 0){
                saldoMedio = acumuladorSaldo/contadorOperacoes;
            }
            return saldoMedio;
        }
    }

    public void Depositar(decimal val)
    {
        saldo += val;
        acumuladorSaldo += saldo;
        contadorOperacoes++;
    }

    public void Sacar(decimal val)
    {
        saldo -= val;
        acumuladorSaldo += saldo;
        contadorOperacoes++;

    }

}