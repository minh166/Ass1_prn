using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        MemberDAO memberDAO = new MemberDAO();
        public void AddMember(MemberObject mem)
        {
            memberDAO.Add(mem);
        }

        public void DeleteMember(int memberId)
        {
            memberDAO.Remove(memberId);
        }

        public MemberObject GetMemberByID(int memberId)
        {
            return memberDAO.GetMemberById(memberId);
        }

        public List<MemberObject> GetMembers()
        {
            return memberDAO.GetMemberList();
        }

        public bool Login(string email, string password)
        {
            return memberDAO.Login(email, password);
        }
    }
}
