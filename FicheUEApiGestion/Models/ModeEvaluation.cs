namespace FicheUEApiGestion.Models;

public class ModeEvaluation
{
    [Key]
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    [ForeignKey(nameof(TypeEvaluation))]
    public int TypeEvaluationId { get; set; }
    [NotMapped]
    public TypeEvaluation? TypeEvaluation { get; set; }

}
