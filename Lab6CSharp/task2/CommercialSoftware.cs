

using Lab6CSharp.task2;

namespace Lab6CSharp
{
    class CommercialSoftware :ISoftware
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate {  get; set; }
        public int UsageDays { get; set; }  

        public decimal UsagePrice { get; set; }


        public bool canUse(DateTime currentDate)
        {
            DateTime installationDate = InstallationDate.Date;

            currentDate = currentDate.Date;
            
            int daysdiff = (currentDate-installationDate).Days;
            if (daysdiff<=UsageDays)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}\nInstallation Date: {InstallationDate}\nUsage Days: {UsageDays}\nPrice: {UsagePrice}\n");
        }
    }
}
