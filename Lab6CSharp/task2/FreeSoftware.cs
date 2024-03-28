

using Lab6CSharp.task2;

namespace Lab6CSharp
{
     class FreeSoftware:ISoftware
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}");
        }

        public bool canUse(DateTime currentDate)
        {
            return true;
        }

        
    }
}
