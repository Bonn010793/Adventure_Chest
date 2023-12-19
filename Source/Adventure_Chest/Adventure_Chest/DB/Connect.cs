using System;
using Npgsql;
using Microsoft.Extensions.Configuration;
namespace Adventure_Chest.DB
{
	public class Connect
	{
        private static IConfiguration Configuration { get; set; }
        static Connect()
		{
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("connect.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
        }
        public Connect()
        {
            string SqlConnectionString = Configuration["SqlConnect"];
            // остальной код
        }
    }
}

