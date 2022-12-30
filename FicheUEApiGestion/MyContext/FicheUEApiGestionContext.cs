namespace FicheUEApiGestion.MyContext;

public class FicheUEApiGestionContext : DbContext
{

	public FicheUEApiGestionContext(DbContextOptions<FicheUEApiGestionContext> options) : base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Langue>().HasData
        (
            new Langue
            {
				Id = 1,
                Libelle = "Français"
            },
			new Langue
			{
				Id = 2,
				Libelle = "Anglais"
			},
			new Langue
			{
				Id = 3,
				Libelle = "Espagnol"
			},
			new Langue
			{
				Id = 4,
				Libelle = "Néerlandais"
			}
		) ;
    }

   public DbSet<Langue> Langues { get; set; } = default!;
   public DbSet<ModeEvaluation> ModeEvaluations { get; set; } = default!;
   public DbSet<Enseignant> Enseignants { get; set; } = default!;
   public DbSet<Cours> Cours { get; set; } = default!;
   public DbSet<Cursus> Cursus { get; set; } = default!;
   public DbSet<Competence> Competences { get; set; } = default!;
   public DbSet<Capacite> Capacites { get; set; } = default!;
   public DbSet<Libre> Libres { get; set; } = default!;
   public DbSet<UE> UEs { get; set; } = default!;
   public DbSet<AdminField> AdminFields { get; set; } = default!;
   public DbSet<TypeEvaluation> TypeEvaluations { get; set; } = default!;
   
}
