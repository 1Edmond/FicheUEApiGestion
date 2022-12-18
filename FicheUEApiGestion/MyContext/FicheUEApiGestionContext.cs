using Microsoft.EntityFrameworkCore;

namespace FicheUEApiGestion.MyContext;

public class FicheUEApiGestionContext : DbContext
{

	public FicheUEApiGestionContext(DbContextOptions<FicheUEApiGestionContext> options) : base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        
        base.OnModelCreating(modelBuilder);

    }


}
