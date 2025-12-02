
ContaBancaria conta1 = new ContaBancaria("1234-5",1000.00);

Console.WriteLine($@"Conta: {conta1.NumeroConta}
Saldo atual: {conta1.Saldo}");

conta1.Depositar(500.00);
Console.WriteLine(@$"Deposito realizado.
Saldo atual: {conta1.Saldo}");
