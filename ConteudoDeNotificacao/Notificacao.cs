public sealed class Notificacao
{
    public Notificacao()
    {

    }

    public Notificacao(string propriedades, string mensagem)
    {
        Propriedades = propriedades;
        Mensagem = mensagem;
    }

    public string Propriedades { get; set; }
    public string Mensagem { get; set; }
}