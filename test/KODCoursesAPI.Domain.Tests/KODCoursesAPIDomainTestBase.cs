using Volo.Abp.Modularity;

namespace KODCoursesAPI;

/* Inherit from this class for your domain layer tests. */
public abstract class KODCoursesAPIDomainTestBase<TStartupModule> : KODCoursesAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
