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

        public void AddMember(MemberData member)
        {
            var newMember = new Member()
            {
                Name = member.Name,
                Surname = member.Surname,
                SexId = member.SexId,
                Adress = new Adress()
                {
                    Street = member.Street,
                    City = member.City,
                    PostalCode = member.PostalCode
                }
            };
            context.Members.Add(newMember);
            context.SaveChanges();

        }

        public void DeleteMember(int id)
        {
            var member = context.Members
                .FirstOrDefault(p => p.Id == id);
            context.Members.Remove(member);
            context.SaveChanges();
        }

        public void EditMember(MemberData member)
        {
            var memberToEdit = context.Members.FirstOrDefault(p => p.Id == member.Id);

            memberToEdit.Name = member.Name;
            memberToEdit.Surname = member.Surname;
            memberToEdit.SexId = member.SexId;
            memberToEdit.Adress.Street = member.Street;
            memberToEdit.Adress.City = member.City;
            memberToEdit.Adress.PostalCode = member.PostalCode;

            context.SaveChanges();
        }

        public List<MemberData> GetAllMembers()
        {
            var allMembers = context.Members.ToList();

            List<MemberData> members = new List<MemberData>();
             
            foreach (var item in allMembers)
            {

                var member = MemberDateMapper(item);
                members.Add(member);
            }

            return members;
        }

        public MemberData GetMemberById(int id)
        {
            var member = context.Members.FirstOrDefault(p => p.Id == id);

            return MemberDateMapper(member);
        }

        private MemberData MemberDateMapper(Member member) 
        {
            var memberData = new MemberData()
            {
                Id = member.Id,
                Name = member.Name,
                Surname = member.Surname,
                SexId = (int)member.SexId,
                Street = member.Adress.Street,
                City = member.Adress.City,
                PostalCode = member.Adress.PostalCode

            };
            return memberData;

        }
    }
}
