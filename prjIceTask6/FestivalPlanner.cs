namespace prjIceTask6
{

    // Define the FestivalPlanner class
    public class FestivalPlanner
    {
        private BandAnnouncementDelegate bandAnnouncementDelegate;
        private StagePerformanceDelegate stagePerformanceDelegate;
        private Dictionary<DateTime, Band> bandSchedule;

        public FestivalPlanner()
        {
            bandSchedule = new Dictionary<DateTime, Band>();
        }

        // Method to register bands for announcement
        public void RegisterBandAnnouncement(BandAnnouncementDelegate delegateMethod)
        {
            bandAnnouncementDelegate += delegateMethod;
        }

        // Method to register stage performances
        public void RegisterStagePerformance(StagePerformanceDelegate delegateMethod)
        {
            stagePerformanceDelegate += delegateMethod;
        }

        // Method to simulate the festival
        public void SimulateFestival()
        {
            // Sort bands based on their time slots
            var sortedBands = bandSchedule.OrderBy(x => x.Key);

            // Announce each band and start their performance according to the schedule
            foreach (var kvp in sortedBands)
            {
                bandAnnouncementDelegate?.Invoke(kvp.Value);
                stagePerformanceDelegate?.Invoke();
                Console.WriteLine($"{kvp.Value.Name} ({kvp.Value.Genre}) performs at {kvp.Key.ToString("HH:mm")}");
            }
        }

        // Method to add bands to the festival lineup
        public void AddBand(Band band)
        {
            bandSchedule.Add(band.TimeSlot, band);
        }
    }
}

