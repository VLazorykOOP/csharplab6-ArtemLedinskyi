

namespace Lab5CSharp
{
    class CommercialSoftware : Software
    { 
        public DateTime InstallationDate {  get; set; }
        public int UsageDays { get; set; }  

        public decimal UsagePrice { get; set; }


        public override bool canUse(DateTime currentDate)
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

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}\nInstallation Date: {InstallationDate}\nUsage Days: {UsageDays}\nPrice: {UsagePrice}\n");
        }
    }
}
