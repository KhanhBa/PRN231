using NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceMember
{
    public class Service1 : IService1
    {
        private MemberManager _data;
        public Service1()
        {
            _data = new MemberManager();
        }

        public Service1(MemberManager data)
        {
            _data = data;
        }

        public List<Member> Create(Member member)
        {
            List<Member> members = _data.GetAll();
            if (member == null)
            {
                return members;
            }
            members.Add(member);
            return members;
        }

        public List<Member> Delete(int memberId)
        {
            List<Member> members = _data.GetAll();
            var existingMember = _data.members.Find(m => m.Id == memberId);
            if (existingMember == null)
            {
                return members;
            }
            members.Remove(existingMember);
            return members;
        }

        public List<Member> GetData()
        {
            return _data.GetAll();
        }

        public List<Member> Update(Member member)
        {
            List<Member> members = _data.GetAll();
            var existingMember = _data.members.Find(m => m.Id == member.Id);
            if (existingMember != null)
            {
                existingMember.Name = member.Name;
                existingMember.Age = member.Age;
                existingMember.Salary = member.Salary;
                existingMember.UserName = member.UserName;
                existingMember.Password = member.Password;
            }
            else
            {
                throw new Exception("Member not found.");
            }
            return members;
        }
    }
}
