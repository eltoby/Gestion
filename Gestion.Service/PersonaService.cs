namespace Gestion.Service
{
    using Gestion.Wcf.Contracts;
    using AutoMapper;
    using Gestion.Domain;
    using Gestion.DataAccess;
    using System.Collections.Generic;
    using System.Linq;

    public class PersonaService : IPersonaWcf
    {
        public IEnumerable<PersonaDto> GetAll()
        {
            IEnumerable<Persona> personas;
            using (var ctx = new GestionContext())
                personas = ctx.Personas.ToArray();

            Mapper.CreateMap<Persona, PersonaDto>();
            var dtos = Mapper.Map<IEnumerable<PersonaDto>>(personas);
            return dtos;
        }

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
