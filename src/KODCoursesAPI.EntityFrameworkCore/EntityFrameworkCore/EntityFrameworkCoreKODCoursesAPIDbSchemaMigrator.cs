using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KODCoursesAPI.Data;
using Volo.Abp.DependencyInjection;

namespace KODCoursesAPI.EntityFrameworkCore;

public class EntityFrameworkCoreKODCoursesAPIDbSchemaMigrator
    : IKODCoursesAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreKODCoursesAPIDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the KODCoursesAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<KODCoursesAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
