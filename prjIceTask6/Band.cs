namespace prjIceTask6
{

    // Define the Band class
    public class Band
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime TimeSlot { get; set; }
    }

    // Define delegates
    public delegate void BandAnnouncementDelegate(Band band);
    public delegate void StagePerformanceDelegate();
}
