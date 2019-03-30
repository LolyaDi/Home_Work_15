using System;

namespace Home_Work_15
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public int Cost { get; set; }

        public int PublicYear { get; set; }

        public Book(string name, int cost, string author, int publicYear)
        {
            Name = name;
            Cost = cost;
            Author = author;
            PublicYear = publicYear;
        }
    }
}
