using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url)
        : base(titulo, url)
        {
            Modulos = new List<Modulo>();
        }
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoLevel Level { get; set; }
    }
}