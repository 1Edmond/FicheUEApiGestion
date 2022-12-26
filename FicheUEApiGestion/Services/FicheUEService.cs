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
        string departement = "TECHNOLOGIE & ECONOMIE";
        string cursus = "INFORMATIQUE DE GESTION";
        string orientation = "Sans objet";
        string implantation = "Campus de La Plaine / Bâtiment HA, Boulevard du Triomphe, 1, 1050 Bruxelles";
        string telephone = "02/340 16 70";
        string cycle = "1";
        string bloc = "1";
        string situation = "quadrimestre 2";
        string niveau = "Niveau 7";
        string volume = "52h";
        var dict = new Dictionary<string, string>()
            {
                { nameof(departement) ,departement },
                { nameof(cursus) ,cursus },
                { nameof(orientation) ,orientation },
                { nameof(implantation) ,implantation },
                { nameof(telephone) ,telephone },
                { nameof(cycle) ,cycle },
                { nameof(bloc) ,bloc },
                { nameof(situation) ,situation },
                { nameof(niveau) ,niveau },
                { nameof(volume) ,volume },
            };
        Test(dict);
        return Task.FromResult(true);
    }



    public void Test(Dictionary<string, string> dict)
    {
        var a = Document.Create(container =>
        {

            container.Page(page =>
            {
                page.Size(PageSizes.A3);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);

                page.Header()
                   .AddFicheHeader();

                page.Footer().AlignCenter().Column(c =>
                {
                    c.Item().Text("HELB Ilya Prigogine. Fiche descriptive IG UE 2-6 (2022-2023)");

                });
                page.Content()
                .Column(col =>
                {
                    col.Item()
                    .AddUEHeader();

                    col.Item()
                    .Table(table =>
                    {

                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(720);
                            //columns.ConstantColumn(100);
                        });

                        // by using custom 'Element' method, we can reuse visual configuration
                        table.
                            AddLigne1(dict["departement"])
                            .AddLigne2(dict["cursus"], dict["orientation"])
                            .AddLigne3(dict["implantation"], dict["telephone"])
                            .AddLigne4("4")
                            .AddLigne5("5")
                            .AddLigne6("6")
                            .AddLigne7("7")
                            .AddLigne8("8")
                            .AddLigne9("9")
                            .AddLigne10("10")
                            .AddLigne11("11")
                            .AddLigne12("12")
                            .AddLigne13("13")
                            .AddLigne14("14")
                            .AddLigne15("Support en tête")
                            .AddLigne16("Support donnée")
                            .AddLigne17("Modalités en tête")
                            .AddLigne18("Modalités données")
                            ;

                        // for simplicity, you can also use extension method described in the "Extending DSL" section

                        // the Block() method, that defines default cell style, is omitted
                    });

                    col.Item().AddFicheOtherInformation();
                });
            });
        });
        a.GeneratePdf("Files/test.pdf");
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
