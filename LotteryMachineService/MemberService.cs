using LotteryMachineService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LotteryMachineService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class MemberService : IMemberService
    {
        LotteryMachineDbContext context = new LotteryMachineDbContext();
        public void AddMember(string name, string surname, int sex, string street, string city, string postal)
        {
            

            var newMember = new Member()
            {

                Name = name,
                Surname = surname,
                SexId = sex,
                Adress = new Adress()
                {
                    Street = street,
                    City = city,
                    PostalCode = postal

                }
            };

            context.Members.Add(newMember);
            context.SaveChanges();
            
        }

        public Member get(int id)
        {
            var a = context.Members.FirstOrDefault(p => p.Id == id);
            Member member = new Member
            {
                Name = a.Name,
                Surname = a.Surname,
                SexId = a.SexId,
                Adress = a.Adress
            };
            return member;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public CompositeType IMemberService(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
