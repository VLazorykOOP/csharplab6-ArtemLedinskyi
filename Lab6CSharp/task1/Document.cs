using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task1
{
    internal class Document : IDocument,IComparable<Document>
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }


        public Document()
        {
            Console.WriteLine("Конструктор без параметрiв викликаний.(Document)");
        }



        public Document(string title, DateTime date)
        {
            Title = title;
            Date = date;
            Console.WriteLine("Конструктор з двома парааметрами викликаний.(Document)");
        }

        public Document(string title)
        {
            Title = title;
            Console.WriteLine("Конструктор з одним параметром викликаний.(Document)");
        }

        ~Document()
        {
            Console.WriteLine("Викликано деструктор(Document).");
        }


        public virtual void Show()
        {
            Console.WriteLine($"Title: {Title}\nDate: {Date}");

        }

        public int CompareTo(Document other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}
