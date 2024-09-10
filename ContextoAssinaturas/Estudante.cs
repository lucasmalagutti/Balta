public class Estudante : Base
{
    public Estudante()
    {
        Assinaturas = new List<Assinatura>();
    }
    public string Nome { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Assinatura> Assinaturas { get; set; }
    public void CriarAssinatura(Assinatura assinatura)
    {
        if (Premiun)
        {
            AddNotificacao(new Notificacao("Premiun", "O aluno já tem a assinatura"));
            return;
        }
        else
        {
            Assinaturas.Add(assinatura);
        }
    }
    public bool Premiun => Assinaturas.Any(x => !x.Inativo);
}