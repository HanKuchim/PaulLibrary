using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulLibrary
{
    class User
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }

        public List<Book>  UserBook = new List<Book>();

        public User(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
