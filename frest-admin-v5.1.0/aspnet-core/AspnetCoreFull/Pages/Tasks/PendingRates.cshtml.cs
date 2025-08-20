using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspnetCoreFull.Pages.Tasks
{
    // This class defines the structure for one row in our table
    public class BookingEntry
    {
        public string Segment { get; set; }
        public string BookingNo { get; set; }
        public string BookingDate { get; set; }
        public string CarrierBookingNo { get; set; }
        public string BookingPerson { get; set; }
        public string ShipperCode { get; set; }
        public string ShipperName { get; set; }
    }

    public class PendingRatesModel : PageModel
    {
        // This property will hold our list of bookings to display
        public List<BookingEntry> Bookings { get; set; }

        public void OnGet()
        {
            // TODO: This is where you will query your database for the actual data
            // For now, we create some sample data to show in the table.
            Bookings = new List<BookingEntry>
            {
                new BookingEntry { Segment = "AIR EXPORT", BookingNo = "492113000010", BookingDate = "23-JAN-23", BookingPerson = "PRANJAL DHEKLE", ShipperCode = "C013650", ShipperName = "SRI MURUGAN SILKS" },
                new BookingEntry { Segment = "FCL EXPORT", BookingNo = "492114000389", BookingDate = "06-JUN-24", BookingPerson = "RAMYA T", ShipperCode = "C020897", ShipperName = "RAIGAD CARBIDES" },
                new BookingEntry { Segment = "FCL EXPORT", BookingNo = "492114000453", BookingDate = "31-JUL-24", BookingPerson = "JAVEED KAREMULLAH", ShipperCode = "C020897", ShipperName = "RAIGAD CARBIDES" },
                new BookingEntry { Segment = "FCL EXPORT", BookingNo = "492114000498", BookingDate = "26-AUG-24", BookingPerson = "JAVEED KAREMULLAH", ShipperCode = "C020512", ShipperName = "PRIME GASES PVT LTD" }
            };
        }
    }
}
