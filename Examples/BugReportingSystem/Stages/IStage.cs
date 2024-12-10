using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Stages
{
    public interface IStage
    {
        void Proccess(BugReportingModel input);
    }
}
