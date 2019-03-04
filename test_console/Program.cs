using System;

namespace test_console
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }

        public User(string name, string email, int id)
        {
            this.Name = name;
            this.Email = email;
            this.ID = id;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Random C# things
            User[] users = new User[5];
            string name;

            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Enter my name, boss.");
                name = Console.ReadLine();
                users[i] = new User(name, "esh", i);

            }

            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Name: {0}" , users[i].Name);
            }
        }
    }
}
