using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Sandbox {
    public class Program {
        public static void Main(string[] args) {
            var host = new WebHostBuilder()
                .UseUrls("http://*:5000", "http://0.0.0.0:5000")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}