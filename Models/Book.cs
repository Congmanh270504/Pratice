using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pratice.Models
{
    public class Book
    {
        string name, link, author, description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        int cost;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Book(string name, int cost, string link, string author, string description)
        {
            this.name = name;
            this.cost = cost;
            this.link = link;
            this.author = author;
            this.description = description;
        }
        public Book()
        {
            name = "Sách 1 ";
            cost = 100000;
            link = "OIP(1).jpg";
            author = "Robbert";
            description = "aaaa";
        }
    }
}