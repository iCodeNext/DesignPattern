using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Stages
{
    public class FormattingStage : IStage
    {

        public void Proccess(BugReportingModel input)
        {
            var errors = new List<int>()
            {
                1,2,3,4,5
            };
            if (!errors.Contains(input.Severity))
            {
                throw new Exception("Severity is out of range");
            }
            input.CreateReportTime = DateTime.Now;
        }
    }
}
