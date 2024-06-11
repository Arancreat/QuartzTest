namespace QuartzTest
{
    public interface IMainService
    {
        Task PrintLogAsync();
    }

    public class MainService : IMainService
    {
        private readonly ILogger<IMainService> _logger;

        public MainService(ILogger<IMainService> logger)
        {
            _logger = logger;
        }

        public async Task PrintLogAsync()
        {
            await Task.Delay(1000);
            _logger.LogInformation("Hello from MainService!");
        }
    }
}
