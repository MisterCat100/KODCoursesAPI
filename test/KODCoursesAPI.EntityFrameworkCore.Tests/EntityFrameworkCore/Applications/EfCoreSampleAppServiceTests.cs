using KODCoursesAPI.Samples;
using Xunit;

namespace KODCoursesAPI.EntityFrameworkCore.Applications;

[Collection(KODCoursesAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<KODCoursesAPIEntityFrameworkCoreTestModule>
{

}
