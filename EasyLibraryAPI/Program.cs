using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;



namespace EasyLibraryAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostBuilder(args).Run();
            /*BuildeWebHost(args).Run();*/
        }

        public static IWebHost HostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();

    }
}
