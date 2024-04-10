using Destructurama;
using Serilog;

namespace SerilogMaskingAndEncrytion;

public class Program
{
    public static void Main(string[] args)
    {

        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Destructure.UsingAttributes() // <------------- This here is a must
            .CreateLogger();

        try
        {
            Log.Information("Application Starting Up");


            var builder = Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                });

            var host = builder.Build();
            host.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "The application failed to start correctly");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
