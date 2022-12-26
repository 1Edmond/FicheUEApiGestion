namespace FicheUEApiGestion.MyContext;

public class FicheUEApiGestionContext : DbContext
{

	public FicheUEApiGestionContext(DbContextOptions<FicheUEApiGestionContext> options) : base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        this.AddDefaultDataToDatabase();
        base.OnModelCreating(modelBuilder);
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
