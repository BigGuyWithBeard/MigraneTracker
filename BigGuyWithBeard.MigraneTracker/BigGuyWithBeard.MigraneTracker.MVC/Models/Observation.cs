using System.ComponentModel.DataAnnotations;

namespace BigGuyWithBeard.MigraneTracker.MVC.Models
{
    public class Observation
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Created", Prompt = "Date/Time observation was taken")] 
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Nausea", Prompt = "How nauseous do you feel? 0(not at all) to 9(vommiting)")] 
        public int NauseaScore { get; set; } = 0;

        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Dizzyness", Prompt = "How dizzy are you> 0 (not at all) to 9 (room spins)")] 
        public int DizzynessScore { get; set; } = 0;

        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Light Sensitivity", Prompt = "0 to 9")] 
        public int LightSensitivityScore { get; set; } = 0;

        [Display(Name = "Head Pain", Prompt = "0 to 9")] 
        public int HeadPainScore { get; set; } = 0;

        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Neck Pain", Prompt = "0 to 9")] 
        public int NeckPainScore { get; set; } = 0;

        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Tiredness", Prompt = "0 to 9")]
        public int TirednessScore { get; set; } = 0;
       
        [Range(0, 9, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Function", Prompt = "0 (normal) to 9 (totally impaired)")]
        public int FunctionScore { get; set; } = 0;


        [StringLength(100, ErrorMessage = "Field cannot be longer than 100 characters")]
        [Display(Name = "Medication", Prompt= "Medications since last obs.  eg zapain, sumatripan")] 
        public string Medication { get; set; } = "";


        [StringLength(100, ErrorMessage = "Field cannot be longer than 100 characters")]
        [Display(Name = "Comments")] 
        public string Comments { get; set; } = "";
    }
}
