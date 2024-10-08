namespace NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database
{
    public partial class Member
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public int Salary { get; set; }
        public string UserName { get; set; }
        public string Password {  get; set; }
            public Member(int id, string name, int age, int salary, string username, string password)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
            UserName = username;
            Password = password;
        }

        public Member()
        {
        }
    }
     
}
