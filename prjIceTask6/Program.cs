using prjIceTask6;

namespace prjIceTask6
{
    // Main program
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of bands
            Band band1 = new Band { Name = "The Rockers", Genre = "Rock", TimeSlot = DateTime.Parse("12:00") };
            Band band2 = new Band { Name = "Jazz Ensemble", Genre = "Jazz", TimeSlot = DateTime.Parse("14:00") };
            Band band3 = new Band { Name = "Pop Sensations", Genre = "Pop", TimeSlot = DateTime.Parse("16:00") };

            // Create an instance of FestivalPlanner
            FestivalPlanner festivalPlanner = new FestivalPlanner();

            // Register bands for announcement
            festivalPlanner.RegisterBandAnnouncement(BandAnnouncement);

            // Register stage performances
            festivalPlanner.RegisterStagePerformance(StagePerformance);

            // Add bands to the festival lineup
            festivalPlanner.AddBand(band1);
            festivalPlanner.AddBand(band2);
            festivalPlanner.AddBand(band3);

            // Simulate the festival
            festivalPlanner.SimulateFestival();
        }

        // Method to announce band
        static void BandAnnouncement(Band band)
        {
            Console.WriteLine($"Announcing {band.Name}!");
        }

        // Method to start performance
        static void StagePerformance()
        {
            Console.WriteLine("Starting performance!");
        }
    }
}

