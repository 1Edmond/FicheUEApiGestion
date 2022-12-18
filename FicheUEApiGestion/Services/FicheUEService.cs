namespace FicheUEApiGestion.Services;

public class FicheUEService : IFicheUEService
{
    private const string File = "";
    private const string NewFile = "";
    FicheUEApiGestionContext context;

    public FicheUEService(FicheUEApiGestionContext ficheUEApiGestionContext)
    {
        context = ficheUEApiGestionContext;
    }
    public Task<bool> GeneratePdf()
    {
        UpdateHtmlFile();

        return Task.FromResult(true);
    }

    private void UpdateHtmlFile()
    {

        using(var reader = new StreamReader(File))
        {
            var temp = new HtmlDocument();
            temp.Load(reader);





            using(var writer = new StreamWriter(NewFile))
            {

                temp.Save(writer);
            }

        }
    }

    private HtmlDocument CreateListe(HtmlDocument doc, List<string> data, string Id)
    {
        var HtmlData = doc.GetElementbyId(Id);
        var ul = doc.CreateElement("ul");
        data.ForEach(x =>
        {
            var temp = doc.CreateElement("li");
            temp.InnerHtml = x;
            ul?.AppendChild(temp);
        });
        HtmlData.AppendChild(ul);
        return doc;
    }



    private void GeneratePdfFile()
    {   
        Document.Create(x =>
        {
            x.Page(page =>
            {
                page.HTML(handler =>
                {
                    handler.SetHtml("html");
                });
            });
        });     
    }





}
