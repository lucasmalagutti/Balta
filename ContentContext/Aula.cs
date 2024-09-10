using Balta.ContentContext.Enums;

public class Aula : Base
{
    public int Ordem { get; set; }
    public string Titulo { get; set; }
    public int DuracaoEmMinutos { get; set; }
    public EConteudoLevel Level { get; set; }
}