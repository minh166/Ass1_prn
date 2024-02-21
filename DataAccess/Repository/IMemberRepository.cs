using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<MemberObject> GetMembers();
        MemberObject GetMemberByID(int memberId);
        bool Login(string email, string password);
        void AddMember(MemberObject mem);
        void DeleteMember(int memberId);
    }
}
