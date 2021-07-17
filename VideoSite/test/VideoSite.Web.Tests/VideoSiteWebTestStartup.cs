using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace VideoSite
{
    public class VideoSiteWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<VideoSiteWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}