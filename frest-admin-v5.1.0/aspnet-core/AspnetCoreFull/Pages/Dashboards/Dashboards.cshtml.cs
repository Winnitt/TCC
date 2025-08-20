using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetCoreFull.Pages.Dashboards
{
    public class AnalyticsModel : PageModel
    {
        // --- Properties for EVERY task from your Task Manager ---
        public int BookingsPendingRate { get; set; }
        public int BookingFollowups { get; set; }
        public int PersonwisePendingBookings { get; set; }
        public int JobsNotOpened { get; set; }
        public int PodConnectionsNotUpdated { get; set; }
        public int AtdNotUpdated { get; set; }
        public int BlNotReleased { get; set; }
        public int CanSentDoNotCollected { get; set; }
        public int CfsPendingSeaAirCargo { get; set; }
        public int DocumentsNotAttached { get; set; }
        public int EtaConfirmedCanNotYetSend { get; set; }
        public int ImportCollectChargeNotUpdated { get; set; }
        public int ImportContainerTracking { get; set; }
        public int InvoicesNotRaised { get; set; }
        public int SeaExportJobLpoAndPrq { get; set; }
        public int TranshipmentCargoOverstay { get; set; }
        public int PendingQuotations { get; set; }

        public void OnGet()
        {
            // TODO: Replace all of these with real database queries
            BookingsPendingRate = 15;
            BookingFollowups= 0;
            PersonwisePendingBookings = 4;
            JobsNotOpened = 5;
            PodConnectionsNotUpdated = 12;
            AtdNotUpdated = 2;
            BlNotReleased = 9;
            CanSentDoNotCollected = 3;
            CfsPendingSeaAirCargo = 1;
            DocumentsNotAttached = 7;
            EtaConfirmedCanNotYetSend = 6;
            ImportCollectChargeNotUpdated = 11;
            ImportContainerTracking = 18;
            InvoicesNotRaised = 14;
            SeaExportJobLpoAndPrq = 0;
            TranshipmentCargoOverstay = 2;
            PendingQuotations = 22;
        }
    }
}
