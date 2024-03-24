

namespace Lab5CSharp
{
     class FreeSoftware:Software
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}");
        }

        public override bool canUse(DateTime currentDate)
        {
            return true;
        }

        
    }
}
