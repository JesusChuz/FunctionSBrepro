using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace jesumesbnamespace
{
    public class jesumesbnamespace
    {
        [FunctionName("jesumesbnamespace")]
        public void Run([ServiceBusTrigger("mtsbqueue", Connection = "jesumesbnamespace_SERVICEBUS")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
