using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspnetCoreFull.Pages.Tasks
{
    // A unique name for the data class
    public class JobNotOpenedEntry
    {
        public string Segment { get; set; }
        public string BookingNo { get; set; }
        public string POD { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string Forwader { get; set; }
        public string NotifyCustomer { get; set; }
        public string ETA { get; set; }
        public string Status { get; set; }
    }

    // The Page Model for this specific page
    public class JobNotOpenedModel : PageModel
    {
        public List<JobNotOpenedEntry> Job { get; set; }

        public void OnGet()
        {
            Job = new List<JobNotOpenedEntry>
            {
                new JobNotOpenedEntry { Segment = "AIR EXPORT", BookingNo = "492113000010", POD = "INMAA", Shipper = "SHP_NAME_1", Consignee = "PRANJAL DHEKLE", Forwader = "C013650", NotifyCustomer = "SRI MURUGAN SILKS", ETA="25-JUL-24", Status="Pending" },
                new JobNotOpenedEntry { Segment = "FCL EXPORT", BookingNo = "492114000389", POD = "INMAA", Shipper = "SHP_NAME_2", Consignee = "RAMYA T", Forwader = "C020897", NotifyCustomer = "RAIGAD CARBIDES", ETA="28-JUL-24", Status="Pending" },
            };
        }
    }
}
