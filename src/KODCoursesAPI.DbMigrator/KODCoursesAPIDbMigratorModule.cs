using KODCoursesAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace KODCoursesAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(KODCoursesAPIEntityFrameworkCoreModule),
    typeof(KODCoursesAPIApplicationContractsModule)
)]
public class KODCoursesAPIDbMigratorModule : AbpModule
{
}
