namespace Gestion.Service
{
    using Gestion.Wcf.Contracts;
    using AutoMapper;
    using Gestion.Domain;
    using Gestion.DataAccess;

    public class PersonaService : IPersonaWcf
    {
        public void Alta(PersonaDto dto)
        {
            var persona = new Persona();

            Mapper.CreateMap<PersonaDto, Persona>();
            Mapper.Map(dto, persona);

            using (var ctx = new GestionContext())
            { 
                ctx.Personas.Add(persona);
                ctx.SaveChanges();
            }
        }
    }
}
