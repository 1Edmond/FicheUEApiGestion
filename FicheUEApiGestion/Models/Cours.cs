namespace FicheUEApiGestion.Models; 
public class Cours 
{
	[Key]
	public int Id { get; set; }
	public string Libelle { get; set; } = string.Empty;
	public bool IsOnline { get; set; }
	public string Acquis { get; set; } = string.Empty;
	public bool IsSupportObligatoire { get; set; }
	public string LangueEnseignement { get; set; } = string.Empty;
	public string LangueEvaluation { get; set; } = string.Empty;

	[ForeignKey(nameof(Titulaire))]
	public int TitulaireId { get; set; }
	[NotMapped]
	public Enseignant? Titulaire { get; set; }

	[ForeignKey(nameof(UE))]
	public string CodeUE { get; set; } = string.Empty;

	[NotMapped]
	public UE? UE { get; set; }




}
