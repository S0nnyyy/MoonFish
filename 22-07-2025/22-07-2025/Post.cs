using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_07_2025
{
    class Post
    {
        private string title;
        private string content; 
        private DateTime dateCreated;
        private string author;
        public Post(string title, string content, string author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
            this.dateCreated = DateTime.Now;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public string Authora
        {
            get { return author; }
            set { author = value; }
        }
        public void Output()
        {
            Console.WriteLine($"Title: {title}\nContent: {content}\nAuthor: {author}\nDate Created: {dateCreated}");
        }

    }
}
