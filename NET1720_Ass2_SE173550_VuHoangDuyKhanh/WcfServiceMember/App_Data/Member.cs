using System.Runtime.Serialization;

namespace NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database
{
    [DataContract]
    public class Member
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }

        public Member(int id, string name, int age, int salary, string username, string password)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
            UserName = username;
            Password = password;
        }

        public Member() { }
    }
}
