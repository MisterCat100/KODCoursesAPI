using KODCoursesAPI.Samples;
using Xunit;

namespace KODCoursesAPI.EntityFrameworkCore.Domains;

[Collection(KODCoursesAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<KODCoursesAPIEntityFrameworkCoreTestModule>
{

}
