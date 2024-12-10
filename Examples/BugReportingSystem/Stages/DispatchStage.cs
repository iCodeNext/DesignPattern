using Examples.BugReportingSystem.Connector;
using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Stages
{
    public class DispatchStage : IStage
    {
        private readonly List<IConnector> _connectors;
        public DispatchStage(List<IConnector> connectors)
        {
            _connectors = connectors;
        }
        public void Proccess(BugReportingModel input)
        {
            foreach (var connector in _connectors)
            {
                connector.Send(input);
            }
        }
    }
}
