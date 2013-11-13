namespace Gestion.DataAccess
{
    using System.Data.Entity;
    using Gestion.Domain;

    public interface IGestionContext
    {
        IDbSet<Persona> Personas { get; set; }
    }
}
