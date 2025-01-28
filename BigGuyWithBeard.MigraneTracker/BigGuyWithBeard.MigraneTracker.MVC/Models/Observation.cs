namespace BigGuyWithBeard.MigraneTracker.MVC.Models
{
    public class Observation
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int NauseaScore { get; set; } = 0;
        public int DizzynessScore { get; set; } = 0;
        public int LightSensitivityScore { get; set; } = 0;
        public int HeadPainScore { get; set; } = 0;
        public int NeckPainScore { get; set; } = 0;
        public int TirednessScore { get; set; } = 0;
        public int FunctionScore { get; set; } = 0;
        public string Medication { get; set; } = "";
        public string Comments { get; set; } = "";
    }
}
