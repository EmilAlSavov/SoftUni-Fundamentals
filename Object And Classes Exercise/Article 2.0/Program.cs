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
            public override string ToString()
            {
                return $"{this.Title} -{this.Description}:{this.Author}";
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                List<string> articelArgs = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();

                string title = articelArgs[0];
                string description = articelArgs[1];
                string author = articelArgs[2];

                Article article = new Article() {Title = title, Description = description, Author = author};
                articles.Add(article);
            }

            string type = Console.ReadLine();

            if (type == "title")
            {
               articles = articles.OrderBy(d => d.Title).ToList();
            }else if (type == "content")
            {
                articles = articles.OrderBy(d => d.Description).ToList();
            }
            else if (type == "author")
            {
                articles = articles.OrderBy(d => d.Author).ToList();
            }

            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine(articles[i]);
            }
        }
    }
}
