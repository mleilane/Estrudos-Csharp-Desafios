class ContaBancaria
{
    public string NumeroConta;
    public double Saldo;

    public ContaBancaria(string numeroConta, double saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }


}