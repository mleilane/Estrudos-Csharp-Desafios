class Filme
{
    public string Titulo;
    public int ClassificacaoEtaria;

    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;   
    }

    public string ExibirResultado (int idadeUsuario)
    {
        if(PodeAssistir (idadeUsuario))
        {
            return $"Usúario com {idadeUsuario} anos pode assistir ao filme {Titulo}";
        }
        else
        {
            return $"Usúario com {idadeUsuario} anos não pode assistir ao filme {Titulo}";
        }
    }
}