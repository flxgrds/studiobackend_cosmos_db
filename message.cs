using Newtonsoft.Json;
using Azure;
using Azure.Core.Serialization;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace studiobackend
{
    public class process
    {
        private readonly ILogger _logger;
        private readonly JsonObjectSerializer _serializer;

        public process(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<process>();
            _serializer = new JsonObjectSerializer();
        }

        [Function("process")]
        public UserEventResponse Run(
            [WebPubSubTrigger("flowmodeller", WebPubSubEventType.User, "process")]
                UserEventRequest request,
            string data
        )
        {
            return new UserEventResponse { Data = request.Data, DataType = request.DataType };
        }
    }
}
