using System;

namespace _172252
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
            //result was yeah
            Books[] lib =  { new Books("Метро 2033","Дмитрий Глуховски"),
            new Books("1984","Джордж Оруел"),new Books("Престъпление и наказание","Ф.Достоевски"),
                new Books("Алиса в страната на чудесата","Луис Карол")};
            SortBooks(lib);
            foreach (Books book in lib)
            { Console.WriteLine(book.Title + " - " + book.Author); }
        }
        public static void SortBooks(Books[] booky)
        { int n = booky.Length;
            for (int i = 0; i < n-1; i++) 
            { int minI = i;
                for (int j = i + 1; j < n; j++)
                { if (booky[j].Shortcut < booky[minI].Shortcut)
                        minI = j;
                    (booky[i], booky[minI]) = (booky[minI],booky[i]); } }
        }
    }
}
