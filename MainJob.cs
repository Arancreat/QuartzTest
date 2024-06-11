using Quartz;

namespace QuartzTest
{
    public class MainJob : IJob
    {
        private readonly ILogger<MainJob> _logger;
        private readonly IMainService _mainService;
        
        public MainJob(ILogger<MainJob> logger, IMainService mainService)
        {
            _logger = logger;
            _mainService = mainService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Hello from MainJob!");
            await _mainService.PrintLogAsync();
        }
    }
}
