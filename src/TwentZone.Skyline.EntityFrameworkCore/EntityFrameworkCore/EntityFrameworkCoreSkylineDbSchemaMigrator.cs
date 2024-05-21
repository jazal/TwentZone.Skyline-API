using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TwentZone.Skyline.Data;
using Volo.Abp.DependencyInjection;

namespace TwentZone.Skyline.EntityFrameworkCore;

public class EntityFrameworkCoreSkylineDbSchemaMigrator
    : ISkylineDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSkylineDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SkylineDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SkylineDbContext>()
            .Database
            .MigrateAsync();
    }
}
