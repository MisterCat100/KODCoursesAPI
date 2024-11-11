using Volo.Abp.Modularity;

namespace KODCoursesAPI;

[DependsOn(
    typeof(KODCoursesAPIApplicationModule),
    typeof(KODCoursesAPIDomainTestModule)
)]
public class KODCoursesAPIApplicationTestModule : AbpModule
{

}
