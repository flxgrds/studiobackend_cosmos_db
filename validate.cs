using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace studiobackend
{
    public class validate
    {
        private readonly ILogger _logger;

        public validate(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<validate>();
        }

        [Function("validate")]
        public HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Function, "options", Route = "validate")]
                HttpRequestData req
        )
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Webhook-Allowed-Origin", "*");

            return response;
        }
    }
}
