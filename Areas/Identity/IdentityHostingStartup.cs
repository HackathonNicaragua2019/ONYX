using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnyxPlataform.Models;

[assembly: HostingStartup(typeof(OnyxPlataform.Areas.Identity.IdentityHostingStartup))]
namespace OnyxPlataform.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AplicationDbContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("OnyxPlataformContext")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<AplicationDbContext>();
            });
        }
    }
}