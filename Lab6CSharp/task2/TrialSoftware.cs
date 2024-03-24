namespace Lab5CSharp
{
     class TrialSoftware:Software
    {
        public DateTime InstallationDate {  get; set; } 
        public int FreeUsageDay { get; set;}

        public override bool canUse(DateTime currentDate)
        {
            int daysDiff = (currentDate-InstallationDate).Days;
            if(daysDiff <= FreeUsageDay)
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
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}\nInstallation Date: {InstallationDate}\nFree Usage Day: {FreeUsageDay}\n");



        }
    }
}
