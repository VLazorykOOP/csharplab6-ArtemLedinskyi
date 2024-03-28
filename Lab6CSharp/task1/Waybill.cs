using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task1
{
    internal class Waybill : Document
    {
        private string CompanyName { get; set; }
        private decimal TotalAmount { get; set; }

        public Waybill() : base()
        {
            Console.WriteLine("Конструктор без параметрів виккликаний(Waybill).");
        }


        public Waybill(string companyName, decimal totalAmount) : base("Waybill")
        {
            CompanyName = companyName;
            TotalAmount = totalAmount;
            Console.WriteLine("Конструктор з двома параметрами викликаний(Waybill).");
        }

        public Waybill(string title, DateTime date, string companyName, decimal totalAmount) : base(title, date)
        {
            CompanyName = companyName;
            TotalAmount = totalAmount;
            Console.WriteLine("Конструктор з чотирима параметрами викликаний(Waybill).");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Company Name: {CompanyName}\nTotal Amount: {TotalAmount}");
        }


    }
}
