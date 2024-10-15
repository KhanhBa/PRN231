
using System.Security.Claims;
using System.Text;

namespace NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database
{
    public class MemberManager
    {
        public MemberManager()
        {
            members = new List<Member>();
            Load();
        }
        public List<Member> members = new List<Member>();
        public void Load()
        {
            members.Add(new Member(1,"Khanh",21,2000,"khanhsky","123456"));
            members.Add(new Member(2,"Tuan",22,5000, "Tuan", "123456"));
            members.Add(new Member(3,"Tien",2,6000, "Tien", "123456"));
            members.Add(new Member(4,"Bao",18,7000, "Bao", "123456"));
            members.Add(new Member(5,"Manh",23,4000, "Manh", "123456"));
            members.Add(new Member(6,"Nguyen",30,5000, "Nguyen", "123456"));
            members.Add(new Member(7,"Vu",31,9000, "Vu", "123456"));
            members.Add(new Member(8,"Hoang",20,8000, "Hoang", "123456"));
            members.Add(new Member(9,"Hiep",10,7000, "Hiep", "123456"));
            members.Add(new Member(10,"Binh",21,5000, "Binh", "123456"));
        }
        public List<Member> GetAll()
        {
            return members;
        }
    }
}
