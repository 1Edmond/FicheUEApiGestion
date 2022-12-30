namespace FicheUEApiGestion.Models;

public class UE
{
	[Key]
	public string CodeUE { get; set; } = string.Empty;
	public string Departement { get; set; } = string.Empty;
	public string Orientation { get; set; } = string.Empty;
	public string Implantation { get; set; } = string.Empty;
	public string Situation { get; set; } = string.Empty;
	public int BlocEtudes { get; set; }
	public string NomUE { get; set; } = string.Empty;
	public string UEPrerequises { get; set; } = string.Empty;
	public string UECorequises { get; set; } = string.Empty;
	public int VolumeHoraire { get; set; }
	public int NbrCredits { get; set; }
	[ForeignKey(nameof(Responsable))]
	public int ResponsableId { get; set; }
	[NotMapped]
	public Enseignant? Responsable { get; set; }

	[NotMapped]
	public List<Cours> Cours { get; set; } = new();
	public string Competences { get; set; } = string.Empty;

	public float NoteUE { get; set; }


}
