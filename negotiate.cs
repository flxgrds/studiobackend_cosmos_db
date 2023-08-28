using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace studiobackend
{
    public class negotiate
    {
        private readonly ILogger _logger;

        public negotiate(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<negotiate>();
        }

        [Function("negotiate")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", "options")] HttpRequestData req,
        [WebPubSubConnectionInput(Hub = "flowmodeller", UserId = "{query.userid}")] WebPubSubConnection connectionInfo)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(connectionInfo);
            return response;
        }
    }
}
