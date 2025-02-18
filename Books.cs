using System;
using System.Collections.Generic;
using System.Text;

namespace _172252
{
    class Books
    { public string Title { get; set; }
        public string Author { get; set; }
        public char Shortcut { get; set; }
        public Books(string title,string author)
        { Title = title;
            Author = author;
            Shortcut = title.ToCharArray()[0];
        }
    }
}
