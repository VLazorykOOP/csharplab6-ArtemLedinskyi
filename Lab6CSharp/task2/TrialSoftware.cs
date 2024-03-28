using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6CSharp.task2
{
     class TrialSoftware:ISoftware
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate {  get; set; } 
        public int FreeUsageDay { get; set;}

        public bool canUse(DateTime currentDate)
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

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}\nInstallation Date: {InstallationDate}\nFree Usage Day: {FreeUsageDay}\n");



        }
    }
}
