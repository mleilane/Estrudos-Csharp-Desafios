class Produto
{
    public string Nome;
    private int QuantidadeEstoque;

    public Produto(string nome, int quantidadeEstoque)
    {
        Nome = nome;
        QuantidadeEstoque = quantidadeEstoque;
    }
    

    public string Retirar(int quantidade)
    {
        if (quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
           return $"Retirada de {quantidade} unidades realizada com sucesso";
        }
        else
        {
            return $"Erro: A quantidade informada é superior ao estoque disponivel: {QuantidadeEstoque}";
        }
        
    }

    public string ExibirEstoque()
    {
        return $"Estoque: {QuantidadeEstoque}";
    }
}
