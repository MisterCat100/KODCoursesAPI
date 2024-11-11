using Volo.Abp.Modularity;

namespace KODCoursesAPI;

public abstract class KODCoursesAPIApplicationTestBase<TStartupModule> : KODCoursesAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
