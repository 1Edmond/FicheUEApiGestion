namespace FicheUEApiGestion.Models;
public class Competence
{
    [Key]
    public int Id { get; set; }
    public string Libelle { get; set; } = string.Empty;
}
