using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab_06
{


    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }
    }




    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
    {
        new User { Name = "a", Role = "ADMIN"},
        new User { Name = "b", Role = "MODERATOR"},
        new User { Name = "c", Role = "TEACHER"},
        new User { Name = "d", Role = "STUDENT"}

    };

            Console.WriteLine("Number of users in the list " + users.Count);

            Console.WriteLine(users.Count());


            var u = users.Select(u => u.Name).ToList();

            var u2 = users.OrderBy(u => u.Name);

            List<string> u2_2 = (from user in users orderby user.Name select user.Name).ToList();

            foreach (string name in u2_2)
                Console.WriteLine(name);


            foreach(var user in u2)
            {
                Console.WriteLine(user);
            }

            var roles = new List<User>()
            {
                new User { Role = "ADMIN"},
                new User { Role = "MODERATOR"},
                new User { Role = "TEACHER"},
                new User { Role = "STUDENT"}
            };

            
        }

    }






}



