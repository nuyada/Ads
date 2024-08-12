using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Login = "user1", Name = "Иван", IsPremium = true },
                new User { Login = "user2", Name = "Мария", IsPremium = false },
                new User { Login = "user3", Name = "Алексей", IsPremium = false }
                
            };
            foreach(var user in users)
            {
                CheckForAds.GreetUser(user);
            }
        }
        
    }
   
}
