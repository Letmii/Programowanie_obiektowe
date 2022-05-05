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
        new User { Name = "u", Role = "ADMIN", Age = 30, Marks = null, CreatedAt = new DateTime(2022, 1, 12) },
        new User { Name = "t", Role = "MODERATOR", Age = 25, Marks = null, CreatedAt = new DateTime(2022, 1, 27) },
        new User { Name = "s", Role = "TEACHER", Age = 37, Marks = null, CreatedAt = new DateTime(2022, 2, 16) },
        new User { Name = "r", Role = "STUDENT", Age = 15, Marks = new int[] { 1, 4, 2, 5 }, CreatedAt = new DateTime(2022, 6, 25)},
        new User { Name = "p", Role = "STUDENT", Age = 19, Marks = new int[] { 3, 4, 1, 5 }, CreatedAt = new DateTime(2022, 2, 22)},
        new User { Name = "o", Role = "STUDENT", Age = 16, Marks = new int[] { 4, 4, 3, 3 }, CreatedAt = new DateTime(2022, 5, 2)},
        new User { Name = "n", Role = "STUDENT", Age = 18, Marks = new int[] { 5, 4, 2, 5 }, CreatedAt = new DateTime(2022, 4, 12)},
        new User { Name = "m", Role = "STUDENT", Age = 18, Marks = new int[] { 2, 3, 4, 4 }, CreatedAt = new DateTime(2022, 11, 26)},
        new User { Name = "l", Role = "STUDENT", Age = 16, Marks = new int[] { 3, 3, 5, 5 }, CreatedAt = new DateTime(2022, 12, 21)},
        new User { Name = "k", Role = "STUDENT", Age = 17, Marks = new int[] { 1, 4, 1, 4 }, CreatedAt = new DateTime(2022, 11, 12)},
        new User { Name = "j", Role = "STUDENT", Age = 20, Marks = new int[] { 3, 3, 3, 4 }, CreatedAt = new DateTime(2022, 2, 19)},
        new User { Name = "i", Role = "STUDENT", Age = 19, Marks = new int[] { 2, 4, 1, 5 }, CreatedAt = new DateTime(2022, 2, 7)},
        new User { Name = "h", Role = "STUDENT", Age = 16, Marks = new int[] { 3, 3, 3, 5 }, CreatedAt = new DateTime(2022, 8, 17)},
        new User { Name = "g", Role = "STUDENT", Age = 15, Marks = new int[] { 4, 4, 5, 2 }, CreatedAt = new DateTime(2022, 7, 11)},
        new User { Name = "f", Role = "STUDENT", Age = 17, Marks = new int[] { 3, 3, 1, 3 }, CreatedAt = new DateTime(2022, 6, 3)},
        new User { Name = "e", Role = "STUDENT", Age = 19, Marks = new int[] { 5, 4, 1, 5 }, CreatedAt = new DateTime(2022, 5, 1)},
        new User { Name = "d", Role = "STUDENT", Age = 19, Marks = new int[] { 2, 3, 2, 1 }, CreatedAt = new DateTime(2022, 4, 15)},
        new User { Name = "c", Role = "STUDENT", Age = 14, Marks = new int[] { 1, 3, 3, 3 }, CreatedAt = new DateTime(2022, 3, 27)},
        new User { Name = "b", Role = "STUDENT", Age = 17, Marks = new int[] { 5, 2, 4, 4 }, CreatedAt = new DateTime(2022, 2, 25)},
        new User { Name = "A", Role = "STUDENT", Age = 18, Marks = new int[] { 2, 3, 5, 2 }, CreatedAt = new DateTime(2022, 1, 21)},

    };

            Console.WriteLine("Zadanie 1 :");
            //1 zadanie

            Console.WriteLine("Number of users in the list : " + users.Count);

            Console.WriteLine("Zadanie 2 :");
            //2 zadanie

            List<string> u2_2 = (from user in users select user.Name).ToList();

            foreach (string name in u2_2)
                Console.WriteLine(name);


            Console.WriteLine("Zadanie 3: ");
            //3 zadanie

            List<User> users_1 = (from user in users orderby user.Name select user).ToList();

            foreach(User user in users_1)
                Console.WriteLine(user.Name);

            Console.WriteLine("Zadanie 4 :");
            //4 zadanie
            List<string> roles = (from user in users select user.Role).Distinct().ToList();

            foreach(string role in roles)
                Console.WriteLine(role);

            Console.WriteLine("Zadanie 5 :");
            //5 zadanie
            List<User> usersbyrole = (from user in users orderby user.Role select user).ToList();

            foreach(User user in usersbyrole)
                Console.WriteLine(user.Role + " " + user.Name);

            Console.WriteLine("Zadanie 6 :");
            //6 zadanie
            var count = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Name);
            Console.WriteLine(count.Count());

            

                                   
            
        }

    }






}



