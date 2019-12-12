
using Microsoft.Extensions.Logging;
namespace FrontApp.Controllers
{
    public class testservice:ItestService
    {
        private readonly ILogger<testservice> _logger;
        public testservice(ILogger<testservice> logger){
_logger=logger;
        }
        public void PrintLoggerInfo(){
_logger.LogInformation("THIS IS TEST")
;        }
    }
}