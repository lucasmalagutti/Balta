public abstract class AtorNotificavel
{
    public AtorNotificavel()
    {
        Notificacoes = new List<Notificacao>();
    }
    public List<Notificacao> Notificacoes { get; set; }

    public void AddNotificacao(Notificacao notificacao)
    {
        Notificacoes.Add(notificacao);
    }

    public void AddNotificacoes(IEnumerable<Notificacao> notificacaos)
    {
        Notificacoes.AddRange(notificacaos);
    }
    public bool Invalido => Notificacoes.Any();
}