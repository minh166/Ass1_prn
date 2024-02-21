using System;
using System.Linq;
using System.Collections.Generic;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        public List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject
            {
                MemberID = 1,
                MemberName = "Admin",
                Email = "lmao@gmail.com",
                Password = "admin123",
                City = "Hanoi",
                Country = "Vietnam"
            },
            new MemberObject
            {
                MemberID = 2,
                MemberName = "Minh",
                Email = "minh166@gmail.com",
                Password = "minh123",
                City = "Hanoi",
                Country = "Vietnam"
            },
            new MemberObject
            {
                MemberID = 3,
                MemberName = "Giang",
                Email = "giang123@gmail.com",
                Password = "giang29",
                City = "Hanoi",
                Country = "Vietnam"
            }
        };

        public List<MemberObject> GetMemberList()
        {
            return MemberList;
        }

        public MemberObject GetMemberById(int memberId)
        {
            MemberObject mem = MemberList.SingleOrDefault(mem => mem.MemberID == memberId);
            return mem;
        }

        // Login
        public bool Login(string email, string password)
        {
            bool flag = false;
            foreach (MemberObject mem in MemberList)
            {
                if (mem == null) return flag;
                if (email == mem.Email)
                {
                    if (password == mem.Password)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        // Add new member
        public void Add(MemberObject member)
        {
            MemberObject mem = GetMemberById(member.MemberID);
            if (mem == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists.");
            }
        }

        // Remove a member
        public void Remove(int memberId)
        {
            MemberObject mem = GetMemberById(memberId);
            if (mem != null)
            {
                MemberList.Remove(mem);
            }
            else
            {
                throw new Exception("Member does not exist");
            }
        }
    }
}