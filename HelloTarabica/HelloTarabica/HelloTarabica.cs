namespace HelloTarabica
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Host;

    public static class HelloTarabica
    {
        [FunctionName("HelloTarabica")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello")]
            HttpRequest req,
            TraceWriter log)
        {
            return new OkObjectResult("Hello Tarabica!");
        }
    }
}