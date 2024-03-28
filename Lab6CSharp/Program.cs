using Lab6CSharp.task1;
using Lab6CSharp.task2;
using Lab6CSharp;

namespace Lab6CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DocumentCollection collection = new DocumentCollection();
                    collection.Add(new Document("Document 1", DateTime.Now));
                    collection.Add(new Bill("Customer 1", 100.50m));
                    collection.Add(new Receipt("Receipt 1", DateTime.Now, 50.25m));
                    collection.Add(new Waybill("Company 1", 500.75m));

                    foreach (var doc in collection)
                    {
                        doc.Show();
                        Console.WriteLine("\n");
                    }

                    break;
                case 2:
                    // Створення екземплярів різних типів програмного забезпечення
                    FreeSoftware freeSoftware = new FreeSoftware
                    {
                        Name = "Free Software",
                        Manufacturer = "Free Manufacturer"
                    };

                    TrialSoftware trialSoftware = new TrialSoftware
                    {
                        Name = "Trial Software",
                        Manufacturer = "Trial Manufacturer",
                        InstallationDate = DateTime.Now.AddDays(-5), // Припустимо, що програмне забезпечення було встановлено 5 днів тому
                        FreeUsageDay = 7 // Тривалість пробного періоду в днях
                    };

                    CommercialSoftware commercialSoftware = new CommercialSoftware
                    {
                        Name = "Commercial Software",
                        Manufacturer = "Commercial Manufacturer",
                        InstallationDate = DateTime.Now.AddDays(-10), // Припустимо, що програмне забезпечення було встановлено 10 днів тому
                        UsageDays = 30, // Кількість днів, протягом яких можна використовувати програмне забезпечення
                        UsagePrice = 99.99m // Вартість використання програмного забезпечення
                    };

                    // Виклик методів ShowInfo для кожного типу програмного забезпечення
                    freeSoftware.ShowInfo();
                    trialSoftware.ShowInfo();
                    commercialSoftware.ShowInfo();

                    // Перевірка можливості використання програмного забезпечення на сьогоднішню дату
                    DateTime currentDate = DateTime.Now;
                    Console.WriteLine($"Can use Free Software: {freeSoftware.canUse(currentDate)}");
                    Console.WriteLine($"Can use Trial Software: {trialSoftware.canUse(currentDate)}");
                    Console.WriteLine($"Can use Commercial Software: {commercialSoftware.canUse(currentDate)}");


                    break;
            }

        }
    }
}