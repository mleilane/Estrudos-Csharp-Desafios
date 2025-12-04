class Funcionario
{
    public string Nome;
    public string Cargo;

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Cargo = novoCargo;

            Console.WriteLine(
                $"Promoção efetivada!\n" +
                $"Funcionário: {Nome} \n"+
                $"Cargo Atual: {novoCargo}");

        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual");

        }
    }
}
