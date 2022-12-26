namespace FicheUEApiGestion.Models;

public class Enseignant
{
    [Key]
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;


}
