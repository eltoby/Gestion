namespace Gestion.Wcf.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IPersonaWcf
    {
        [OperationContract]
        IEnumerable<PersonaDto> GetAll();

        [OperationContract]
        void Alta(PersonaDto persona);
    }
}
