using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Stages
{
    public class ValidationStage : IStage
    {
        public void Proccess(BugReportingModel input)
        {
            if (string.IsNullOrWhiteSpace(input.Title) ||
                string.IsNullOrWhiteSpace(input.ReporterName) ||
                string.IsNullOrWhiteSpace(input.Description))
            {
                throw new Exception("Please fill in all the values");
            }
        }
    }
}
