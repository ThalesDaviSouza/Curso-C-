using Sets.Entities;
using System;

namespace Sets {
    class Program {
        static void Main(string[] args) {
            try {
                Course A = new Course();
                Course B = new Course();
                Course C = new Course();

                Console.Write("How many students to course A? ");
                int a = int.Parse(Console.ReadLine());
                
                for(int i = 0; i < a; i++) {
                    Console.Write("#{0} Student id: ", i+1);
                    A.Students.Add(int.Parse(Console.ReadLine()));
                }

                Console.Write("How many students to course B? ");
                int b = int.Parse(Console.ReadLine());

                for (int i = 0; i < b; i++) {
                    Console.Write("#{0} Student id: ", i + 1);
                    B.Students.Add(int.Parse(Console.ReadLine()));
                }

                Console.Write("How many students to course C? ");
                int c = int.Parse(Console.ReadLine());

                for (int i = 0; i < c; i++) {
                    Console.Write("#{0} Student id: ", i + 1);
                    C.Students.Add(int.Parse(Console.ReadLine()));
                }

                HashSet<int> totalStudents = new HashSet<int>();

                totalStudents.UnionWith(A.Students);
                totalStudents.UnionWith(B.Students);
                totalStudents.UnionWith(C.Students);


                Console.WriteLine("Total students: " + totalStudents.Count);

            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}