using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TFTWebApp.infrastructure
{
    public static class InfrastructureExtentions
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<TFTContext>(x => x.UseSqlite("DataSource=..\\TFTWebApp.Infrastructure\\Data\\app.db"));
        }
    }

    
}
