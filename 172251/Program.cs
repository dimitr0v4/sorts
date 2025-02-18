using System;

namespace _172251
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student[] m = new Student[6];
            m[0] = new Student("s1", 17);
            m[1] = new Student("s2", 18);
            m[2] = new Student("s3", 16);
            m[3] = new Student("s4", 16);
            m[4] = new Student("s5", 18);
            m[5] = new Student("s6", 17);
            Sort(m);
            foreach (Student s in m)
            { Console.WriteLine(s.Name + " " + s.Age); }
        }
        public static void Sort(Student[] m)
        {
            int n = m.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (m[j].Age > m[j + 1].Age)
                        (m[j], m[j + 1]) = (m[j + 1], m[j]);
                }
            }
        }
    }
}
