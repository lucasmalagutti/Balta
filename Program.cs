using Balta.ContentContext;

var artigos = new List<Artigo>();
artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
artigos.Add(new Artigo("Artigo sobre C#", "csharp"));
artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

// foreach (var artigo in artigos)
// {
//     Console.WriteLine(artigo.Id);
//     Console.WriteLine(artigo.Titulo);
//     Console.WriteLine(artigo.Url);
// }

var cursos = new List<Curso>();
var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-oop");
var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-csharp");
var cursoAspNet = new Curso("Fundamentos .ASP NET", "fundamentos-dotnet");

cursos.Add(cursoOOP);
cursos.Add(cursoCsharp);
cursos.Add(cursoAspNet);

var carreiras = new List<Carreira>();
var carreiraDotnet = new Carreira("Especialista .NET", "especialista-dotnet");
var itemDaCarreira = new ItemDaCarreira(1, "Comece por aqui", "", cursoCsharp);
var itemDaCarreiraOOP = new ItemDaCarreira(2, "Aprenda OOP", "", cursoOOP);
var itemDaCarreiraAspNet = new ItemDaCarreira(3, "Aprenda .NET", "", null);

carreiraDotnet.ItensDaCarreira.Add(itemDaCarreira);
carreiraDotnet.ItensDaCarreira.Add(itemDaCarreiraOOP);
carreiraDotnet.ItensDaCarreira.Add(itemDaCarreiraAspNet);

carreiras.Add(carreiraDotnet);

foreach (var carreira in carreiras)
{
    Console.WriteLine(carreira.Titulo);
    foreach (var item in carreira.ItensDaCarreira.OrderBy(x => x.Ordem))
    {
        Console.WriteLine($"{item.Ordem} - {item.Titulo}");
        Console.WriteLine($"Curso: {item.Curso?.Titulo}");

        foreach (var notificacao in item.Notificacoes)
        {
            Console.WriteLine($"{notificacao.Propriedades} - {notificacao.Mensagem}");
        }
        var payPalAssinatura = new PayPalAssinatura();
        var estudante = new Estudante();
        estudante.CriarAssinatura(payPalAssinatura);
    }
}