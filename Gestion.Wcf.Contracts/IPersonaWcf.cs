namespace Gestion.Wcf.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IPersonaWcf
    {
        void Alta(PersonaDto persona);
    }
}
