using System.Collections.Generic;
using Conjuntos.Entities;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {
            try {
                string currentDirectory = Directory.GetCurrentDirectory();
                string input = currentDirectory + @"\in.txt";

                if (!File.Exists(input)) {
                    using (StreamWriter sw = File.CreateText(input)) {
                        sw.WriteLine("amanda 2020-08-26T20:45:08");
                        sw.WriteLine("alex86 2020-08-26T21:49:37");
                        sw.WriteLine("bobbrown 2020-08-27T03:19:13");
                        sw.WriteLine("amanda 2020-08-27T08:11:00");
                        sw.WriteLine("jeniffer3 2020-08-27T09:19:24");
                        sw.WriteLine("alex86 2020-08-27T22:39:52");
                        sw.WriteLine("amanda 2020-08-28T07:42:19");
                    }
                }

                using (StreamReader sr = File.OpenText(input)) {
                    SortedSet<UserLog> users = new SortedSet<UserLog>();
                    while (!sr.EndOfStream) {
                        string[] user = sr.ReadLine().Split(' ');
                        users.Add(new UserLog(user[0], DateTime.Parse(user[1])));
                    }

                    Console.WriteLine("Users found:");
                    foreach(UserLog user in users) {
                        Console.WriteLine("- " + user);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Total users: " + users.Count);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}