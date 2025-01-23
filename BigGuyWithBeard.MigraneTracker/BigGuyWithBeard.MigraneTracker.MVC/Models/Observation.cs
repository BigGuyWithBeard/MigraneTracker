namespace BigGuyWithBeard.MigraneTracker.MVC.Models
{
    public class Observation
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
        public int NauseaScore { get; set; } = 0;
        public int DizzynessScore { get; set; } = 0;
        public int LightSensitivtyScore { get; set; } = 0;
        public int HeadPaintScore { get; set; } = 0;
        public int NeckPaintScore { get; set; } = 0;
        public int TirednessScore { get; set; } = 0;
        public int FunctionScore { get; set; } = 0;
        public string Medication { get; set; } = "";
        public string Comments { get; set; } = "";
    }
}
