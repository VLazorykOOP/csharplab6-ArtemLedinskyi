using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task1
{
    internal class Receipt : Document
    {
        private decimal Amount { get; set; }


        public Receipt() : base()
        {
            Console.WriteLine("Виклик конструктора без параметрiв.(Receipt)");
        }

        public Receipt(decimal amount) : base("Receipt")
        {
            Amount = amount;
            Console.WriteLine("Виклик конструктора з одним параметром.(Receipt)");
        }

        public Receipt(string title, DateTime date, decimal amount) : base(title, date)
        {
            Amount = amount;
            Console.WriteLine("Виклик конструктора з трьома параметрами.(Receipt)");
        }

        ~Receipt()
        {
            Console.WriteLine("Викликано деструктор(Receipt).");
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Amount: {Amount}");
        }


    }
}
