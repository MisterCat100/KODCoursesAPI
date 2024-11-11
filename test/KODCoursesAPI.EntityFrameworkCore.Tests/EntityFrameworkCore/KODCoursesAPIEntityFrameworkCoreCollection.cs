using Xunit;

namespace KODCoursesAPI.EntityFrameworkCore;

[CollectionDefinition(KODCoursesAPITestConsts.CollectionDefinitionName)]
public class KODCoursesAPIEntityFrameworkCoreCollection : ICollectionFixture<KODCoursesAPIEntityFrameworkCoreFixture>
{

}
