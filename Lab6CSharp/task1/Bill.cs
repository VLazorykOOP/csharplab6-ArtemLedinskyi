using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task1
{
    internal class Bill : Document
    {
        private string CustomerName { get; set; }
        private decimal AmountDue { get; set; }

        public Bill() : base()
        {
            Console.WriteLine("Конструктор без параметрів викликаний(Bill).");
        }

        public Bill(string customerName, decimal amountDue) : base("Bill")
        {
            CustomerName = customerName;
            AmountDue = amountDue;
            Console.WriteLine("Конструктор з двома параметрами викликаний(Bill).");
        }

        public Bill(string title, DateTime date, string customerName, decimal amountDue) : base(title, date)
        {
            CustomerName = customerName;
            AmountDue = amountDue;
            Console.WriteLine("Конструктор з з чотирима параметрами викликаний(Bill).");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Customer Name: {CustomerName}\nAmount Due{AmountDue}");
        }
    }
    }
