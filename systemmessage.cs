using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace studiobackend
{
    public class systemmessage
    {
        private readonly ILogger _logger;

        public systemmessage(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<systemmessage>();
        }

        [Function("Connect")]
        [WebPubSubOutput(Hub = "flowmodeller")]
        public void Connect(
            [WebPubSubTrigger("flowmodeller", WebPubSubEventType.System, "connect")]
                ConnectEventRequest request
        )
        {
            _logger.LogInformation("Conntect");
        }

        [Function("Connected")]
        [WebPubSubOutput(Hub = "flowmodeller")]
        public void Connected(
            [WebPubSubTrigger("flowmodeller", WebPubSubEventType.System, "Connected")]
                ConnectEventRequest request
        )
        {
            _logger.LogInformation("Connected");
        }

        [Function("Disconnected")]
        [WebPubSubOutput(Hub = "flowmodeller")]
        public void Disconnected(
            [WebPubSubTrigger("flowmodeller", WebPubSubEventType.System, "Disconnected")]
                ConnectEventRequest request
        )
        {
            _logger.LogInformation("Disconnected");
        }
    }
}
