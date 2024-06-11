using Quartz;

namespace QuartzTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddQuartz(q =>
            {
                q.ScheduleJob<MainJob>(trigger => trigger
                    .WithIdentity("Main Trigger")
                    .StartNow()
                    .WithCronSchedule(builder.Configuration["cronSchedule"]!));
            });

            builder.Services.AddQuartzHostedService();
            builder.Services.AddScoped<MainJob>();
            builder.Services.AddScoped<IMainService, MainService>();

            var host = builder.Build();
            host.Run();
        }
    }
}