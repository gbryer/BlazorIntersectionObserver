using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.IntersectionObserver.BasicSamples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIntersectionObserver();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
