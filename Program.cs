using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Opgaver med query's:


            #region Student array

            List<Student> StudentList = new List<Student>();
            //ArrayList StudentList = new ArrayList();

            StudentList.Add(new Student
            {
                id = 1,
                name = "Hans",
                age = 15,
                subjectList = new List<Subject>()
                             {
                                 new Subject(){subjectName="Math", subjectMark=80},
                                 new Subject(){subjectName="English", subjectMark=90},
                                 new Subject(){subjectName="Danish", subjectMark=100}
                             }
            });

            StudentList.Add(new Student
            {
                id = 2,
                name = "Sten",
                age = 16,
                subjectList = new List<Subject>()
                             {
                                 new Subject(){subjectName="Math", subjectMark=75},
                                 new Subject(){subjectName="English", subjectMark=85},
                                 new Subject(){subjectName="Danish", subjectMark=95}
                             }
            });

            StudentList.Add(new Student
            {
                id = 3,
                name = "Lone",
                age = 17,
                subjectList = new List<Subject>()
                             {
                                 new Subject(){subjectName="Math", subjectMark=90},
                                 new Subject(){subjectName="English", subjectMark=95},
                                 new Subject(){subjectName="Danish", subjectMark=100}
                             }
            });

            StudentList.Add(new Student
            {
                id = 4,
                name = "Patrick",
                age = 20,
                subjectList = new List<Subject>()
                             {
                                 new Subject(){subjectName="Math", subjectMark=80},
                                 new Subject(){subjectName="English", subjectMark=90},
                                 new Subject(){subjectName="Danish", subjectMark=100}
                             }
            });

            StudentList.Add(new Student
            {
                id = 5,
                name = "Louise",
                age = 21,
                subjectList = new List<Subject>()
                             {
                                 new Subject(){subjectName="Math", subjectMark=80},
                                 new Subject(){subjectName="English", subjectMark=90},
                                 new Subject(){subjectName="Danish", subjectMark=100}
                             }
            });

            #endregion

            #region Query syntax

            // Første query
            var query1_1 = (from Student student in StudentList
                            where student.name == "Hans"
                            select student).ToList();

            foreach (Student s in query1_1)
            {
                Console.WriteLine("Id " + s.id + ": " + s.name);
            }

            Console.WriteLine("---------------------------------");

            // Anden query
            var query1_2 = (from Student student in StudentList
                            where student.age > 16
                            select student).ToList();

            foreach (Student s in query1_2)
            {
                Console.WriteLine("Id " + s.id + ": " + s.name);
            }

            Console.WriteLine("---------------------------------");

            // Tredje query
            var query1_3 = (from Student student in StudentList
                            where student.id > 1
                            select student).ToList();

            foreach (Student s in query1_3)
            {
                Console.WriteLine(s.name + ": " + s.age + " years old");
            }

            Console.WriteLine("---------------------------------");

            // Fj
            var query1_4 = (from Student student in StudentList
                            where student.age > 20
                            select student).ToList();

            foreach (Student s in query1_4)
            {
                Console.WriteLine("Id " + s.id + ": " + s.name);
            }
            #endregion

            Console.WriteLine("---------------------------------");

            #region Anonymous query

            // Først query

            var AnonQuery_1 = (from Student student in StudentList
                               where student.name == "Lone"
                               select new { Kaffe = student.name }).ToList();

            foreach (var s in AnonQuery_1)
            {
                Console.WriteLine(s.Kaffe);
            }

            Console.WriteLine("---------------------------------");

            // Anden query

            var AnonQuery_2 = (from Student student in StudentList
                               where student.name == "Hans"
                               select new { Te = student.name }).ToList();

            foreach (var s in AnonQuery_2)
            {
                Console.WriteLine(s.Te);
            }

            Console.WriteLine("---------------------------------");

            #endregion

            #region Where query


            var result = StudentList.Where((student) => student.id == 1).ToList();

            foreach (var s in result)
            {
                Console.WriteLine(s.name);
            }

            Console.WriteLine("---------------------------------");

            var result2 = StudentList.Select((student) => student.subjectList.SingleOrDefault((obj) => obj.subjectMark == 100)).ToList();


            Console.WriteLine("---------------------------------");
            #endregion

            #region SingleOrDefault()

            var r = StudentList.SingleOrDefault((student) => student.id == 2);

            Console.WriteLine(r.name);

            #endregion


            Console.ReadKey();
        }
    }
}
