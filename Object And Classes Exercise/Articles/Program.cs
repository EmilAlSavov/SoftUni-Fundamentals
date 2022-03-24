using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    internal class Program
    {
        class Article
        {
            public string Title { get; set; }

            public string Description { get; set; }

            public string Author { get; set; }

            public void Edit(string newDescription)
            {
                this.Description = newDescription;
            }
            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{this.Title} -{this.Description}:{this.Author}";
            }
        }
        static void Main(string[] args)
        {
            List<string> defaultArticle = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
            Article article = new Article() { Title = defaultArticle[0], Description = defaultArticle[1], Author = defaultArticle[2] };
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();

                string type = command[0];
                string content = command[1];

                if (type == "ChangeAuthor")
                {
                    article.ChangeAuthor(content);
                }
                else if (type == "Edit")
                {
                    article.Edit(content);
                }
                else if (type == "Rename")
                {
                    article.Rename(content);
                }
            }
            Console.WriteLine(article);
        }
    }
}
