using Examples.BugReportingSystem.Models;
using Examples.BugReportingSystem.Stages;

namespace Examples.BugReportingSystem
{
    public class BugReportingService
    {
        private readonly List<IStage> stages;
        public BugReportingService()
        {
            stages = new List<IStage>();
        }
        public List<IStage> AddStage(IStage stage)
        {
            stages.Add(stage);
            return stages;
        }

        public void Proccess(BugReportingModel input)
        {
            foreach (var stage in stages)
            {
                stage.Proccess(input);
            }
        }
    }
}
