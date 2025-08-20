using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspnetCoreFull.Pages.Tasks
{
    // Defines the data for a single row in the table
    public class BookingRateEntry
    {
        public string Segment { get; set; }
        public string BookingNo { get; set; }
        public string BookingDate { get; set; }
        public string CarrierBookingNo { get; set; }
        public string BookingPerson { get; set; }
        public string ShipperCode { get; set; }
        public string ShipperName { get; set; }
    }

    public class BookingEnteredButRateNotEnteredModel : PageModel
    {
        // This list will hold our data and pass it to the HTML page
        public List<BookingRateEntry> Bookings { get; set; }

        public void OnGet()
        {
            // TODO: Replace this with a real database query later.
            // Creating 4 dummy data rows exactly like your screenshot.
            Bookings = new List<BookingRateEntry>
            {
                new BookingRateEntry { Segment = "AIR EXPORT", BookingNo = "492113000010", BookingDate = "23-JAN-23", CarrierBookingNo = "", BookingPerson = "PRANJAL DHEKLE", ShipperCode = "C013650", ShipperName = "SRI MURUGAN SILKS" },
                new BookingRateEntry { Segment = "FCL EXPORT", BookingNo = "492114000389", BookingDate = "06-JUN-24", CarrierBookingNo = "", BookingPerson = "RAMYA T", ShipperCode = "C020897", ShipperName = "RAIGAD CARBIDES" },
                new BookingRateEntry { Segment = "FCL EXPORT", BookingNo = "492114000453", BookingDate = "31-JUL-24", CarrierBookingNo = "", BookingPerson = "JAVEED KAREMULLAH", ShipperCode = "C020897", ShipperName = "RAIGAD CARBIDES" },
                new BookingRateEntry { Segment = "FCL EXPORT", BookingNo = "492114000498", BookingDate = "26-AUG-24", CarrierBookingNo = "", BookingPerson = "JAVEED KAREMULLAH", ShipperCode = "C020512", ShipperName = "PRIME GASES PVT LTD" }
            };
        }
    }
}
