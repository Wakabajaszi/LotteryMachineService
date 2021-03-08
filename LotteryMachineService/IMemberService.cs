using LotteryMachineService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LotteryMachineService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IMemberService
    {
        [OperationContract]
         void AddMember(MemberData member);

        [OperationContract]
        List<MemberData> GetAllMembers();

        [OperationContract]
        MemberData GetMemberById(int id);

        [OperationContract]
        void EditMember( MemberData member);

        [OperationContract]
        void DeleteMember(int id);

        // TODO: dodaj tutaj operacje usługi
    }

    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    // Możesz dodać pliki XSD do projektu. Po skompilowaniu projektu możesz bezpośrednio użyć zdefiniowanych w nim typów danych w przestrzeni nazw „LotteryMachineService.ContractType”.
    [DataContract]
    public class MemberData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int SexId { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string PostalCode { get; set; }

        
    }
}
