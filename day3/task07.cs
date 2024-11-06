using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Member
    {
        private string name { get; set; } 
        private string memberId { get; set; }
        private string password;
        private DateTime joiningDate;

        public Member(string name, string memberId, string password)
        {
            this.name = name;
            this.memberId = memberId;          
            this.password = password;
            this.joiningDate = DateTime.Now.Date;
        }
        public void DisplayMemberInfo()
        {
            Console.WriteLine("  Member Information");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("Id        : " + memberId);
            Console.WriteLine("Joined On : " + joiningDate);

        }
    }

    public class AccessMember
    {
        public static void Run()
        {
            Member member1 = new Member("Aaron", "DOL12345", "Passcode");
            member1.DisplayMemberInfo();
        }
    }
}
