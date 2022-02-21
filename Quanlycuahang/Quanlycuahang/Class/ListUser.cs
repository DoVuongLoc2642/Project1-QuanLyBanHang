using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahang.Class
{
    public class ListUser
    {
        private static ListUser instance;

        private List<User> listAccountUser;

        public static ListUser Instance 
        {
            get {
                if (instance == null)
                    instance = new ListUser();
                return instance;
            }
            set => instance = value;
        }

        internal List<User> ListAccountUser { get => listAccountUser; set => listAccountUser = value; }

        private ListUser()
        {
            ListAccountUser = new List<User>();
            ListAccountUser.Add(new User("dovuongloc", "20182642"));
        }
    }
}
