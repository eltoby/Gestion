namespace Gestion.Wcf.Contracts
{
    using System.Runtime.Serialization;
        
    [DataContract(IsReference = true)]
    public class PersonaDto
    {
        [DataMember]
        public int PersonaId { get; set; }

        [DataMember]
        public string Nombre { get; set; }
    }
}
