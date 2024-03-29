using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SBnet6Functionapp
{
    public class ElTimer
    {
        [FunctionName("ElTimer")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Test change SCM_MAX_ZIP_PACKAGE_COUNT Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
