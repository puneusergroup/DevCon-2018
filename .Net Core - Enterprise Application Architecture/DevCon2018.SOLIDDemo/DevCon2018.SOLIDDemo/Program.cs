using System;
using Microsoft.Extensions.DependencyInjection;

namespace DevCon2018.SOLIDDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Provider.GetService<Startup>().Run();
        }
    }

    static class Bootstrapper
    {
        public static ServiceProvider Provider { get; set; }
        static Bootstrapper()
        {
            Provider = new ServiceCollection()
                .AddScoped<IMessageReader, MessageReader>()
                .AddScoped<IMessageWriter, FacebookMessageWriter>()
                .AddScoped<Startup>()
                .BuildServiceProvider();
        }
    }
}
