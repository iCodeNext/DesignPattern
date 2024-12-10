using System.ComponentModel.DataAnnotations;

namespace Examples.BugReportingSystem.Models
{
    public class BugReportingModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Severity { get; set; }
        [Required]
        public string ReporterName { get; set; }
        public DateTime? CreateReportTime { get; set; }
    }
}
