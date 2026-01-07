class Pedido
{
    public string NumeroPedido;
    public string NomeCliente;
    public string Status;

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public string AtualizarStatus(string novoStatus)
    {
        return Status = novoStatus;
    }

    public string ExibirPedido()
    {
        return $"Pedido nº: {NumeroPedido} \nCliente: {NomeCliente} \nStatus: {Status}";
    }
}