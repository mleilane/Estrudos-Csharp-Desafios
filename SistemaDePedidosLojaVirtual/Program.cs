Pedido pedido01 = new Pedido("001","Maria","Pendente");
Console.WriteLine(pedido01.ExibirPedido());

Console.WriteLine("");

pedido01.AtualizarStatus("Enviado");
Console.WriteLine(pedido01.ExibirPedido());