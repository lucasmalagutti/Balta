namespace Balta.ContentContext
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
        : base(titulo, url)
        {
            ItensDaCarreira = new List<ItemDaCarreira>();
        }
        public IList<ItemDaCarreira> ItensDaCarreira { get; set; }
        public int TotalDeCursos => ItensDaCarreira.Count;
    }
}

