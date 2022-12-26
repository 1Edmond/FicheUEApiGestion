namespace FicheUEApiGestion.Models;

public class Langue
{
    [Key]
    public int Id { get; set; }

    public string Libelle { get; set; } = string.Empty;

}

