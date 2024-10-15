using NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceMember
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Member> GetData();

        [OperationContract]
        List<Member> Create(Member member);

        [OperationContract]
        List<Member> Update(Member member);
    }
}
