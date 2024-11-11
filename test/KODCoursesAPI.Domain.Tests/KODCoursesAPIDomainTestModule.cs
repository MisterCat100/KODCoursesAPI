using Volo.Abp.Modularity;

namespace KODCoursesAPI;

[DependsOn(
    typeof(KODCoursesAPIDomainModule),
    typeof(KODCoursesAPITestBaseModule)
)]
public class KODCoursesAPIDomainTestModule : AbpModule
{

}
