namespace Balta.ContentContext
{
    public abstract class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {

            Titulo = titulo;
            Url = url;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}