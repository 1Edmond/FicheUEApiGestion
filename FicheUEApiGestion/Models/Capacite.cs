namespace FicheUEApiGestion.Models;

public class Capacite
{
    [Key]
    public int Id { get; set; }
    public string Libelle { get; set; } = string.Empty;
    [ForeignKey(nameof(Competence))]
    public int CompetenceId { get; set; }

    [NotMapped]
    public Competence? Competence { get; set; }

}
