using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspnetCoreFull.Pages.Tasks
{
    // Defines the data for a single row in the table
    public class BookingPersonwisePending
    {
        public string Segment { get; set; }
        public string BookingNo { get; set; }
        public string BookingDate { get; set; }
        public string HBLHAWBNO { get; set; }
        public string BookingPerson { get; set; }
        public string ForwaderName { get; set; }
        public string ShipperName { get; set; }
        public string ConsigneeName { get; set; }
        public string AgentName { get; set; }

    }

    // THE CLASS NAME MUST END WITH "Model"
    public class BookingPersonwisePendingBookingsModel : PageModel
    {
        // This list will hold our data and pass it to the HTML page
        public List<BookingPersonwisePending> Bookings { get; set; }

        public void OnGet()
        {
            Bookings = new List<BookingPersonwisePending>
            {
                new BookingPersonwisePending { Segment = "AIR EXPORT", BookingNo = "492113000010", BookingDate = "23-JAN-23", HBLHAWBNO = "492113000010", BookingPerson = "PRANJAL DHEKLE", ForwaderName = "", ShipperName = "SRI MURUGAN SILKS",ConsigneeName="PIRRUNTHA SILKS",AgentName="SHENZHEN XUNLAITONG INTERNATIONAL SHIPPING AGENCY CO.,LTD" },
                new BookingPersonwisePending { Segment = "FCL EXPORT", BookingNo = "492114000389", BookingDate = "06-JUN-24", HBLHAWBNO = "SZXLTMAA2403187", BookingPerson = "RAMYA T", ForwaderName = "", ShipperName = "RAIGAD CARBIDES",ConsigneeName="LORDS FREIGHT (INDIA) PRIVATE LIMITED BANGALORE",AgentName="SHENZHEN XUNLAITONG INTERNATIONAL SHIPPING AGENCY CO.,LTD" },
                new BookingPersonwisePending { Segment = "FCL EXPORT", BookingNo = "492114000453", BookingDate = "31-JUL-24", HBLHAWBNO = "HHSE4032564YA.", BookingPerson = "JAVEED KAREMULLAH", ForwaderName = "", ShipperName = "RAIGAD CARBIDES",ConsigneeName="ABRECO FREIGHT PVT LTD (TAMILNADU)",AgentName="WE CAN INTERNATIONAL LOGISTICS ( CO LTD)" },
                new BookingPersonwisePending { Segment = "FCL EXPORT", BookingNo = "492114000498", BookingDate = "26-AUG-24", HBLHAWBNO = "HHSE4017695YA", BookingPerson = "JAVEED KAREMULLAH", ForwaderName = "", ShipperName = "PRIME GASES PVT LTD",ConsigneeName="KRONOS 2 CERAMICHE S P A",AgentName="WE CAN INTERNATIONAL LOGISTICS ( CO LTD)" }
            };
        }
    }
}
