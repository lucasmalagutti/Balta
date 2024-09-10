using Balta.ContentContext;

public class ItemDaCarreira : Base
{
    public ItemDaCarreira(int ordem, string titulo, string descricao, Curso curso)
    {
        if (curso == null)
            AddNotificacao(new Notificacao("Curso", "Curso Invalido"));
        Ordem = ordem;
        Titulo = titulo;
        Descricao = descricao;
        Curso = curso;
    }

    public int Ordem { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public Curso Curso { get; set; }
}