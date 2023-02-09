using Businness.Abstract;
using Businness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WFSinavSonuc
{
    internal static class Program
    {

        [STAThread]
        static void Main()

        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IDersService, DersManager>();
                    services.AddTransient<INotService, NotManager>();
                    services.AddTransient<IOgrenciService, OgrenciManager>();
                    services.AddTransient<IOgrenciDal, EFOgrenciDal>();
                    services.AddTransient<INotDal, EFNotDal>();
                    services.AddTransient<IDersDal, EFDersDal>();

                    services.AddTransient<Form1>();
                });
        }



    }
}