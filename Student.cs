using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTest
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? age { get; set; }

        public List<Subject> subjectList { get; set; }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
