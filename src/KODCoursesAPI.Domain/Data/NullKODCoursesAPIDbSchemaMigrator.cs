using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace KODCoursesAPI.Data;

/* This is used if database provider does't define
 * IKODCoursesAPIDbSchemaMigrator implementation.
 */
public class NullKODCoursesAPIDbSchemaMigrator : IKODCoursesAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
