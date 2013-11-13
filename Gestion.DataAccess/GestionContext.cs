namespace Gestion.DataAccess
{
    using System.Data.Entity;
    using Gestion.Domain;

    public class GestionContext : DbContext
    {
        public GestionContext()
            : base()
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
