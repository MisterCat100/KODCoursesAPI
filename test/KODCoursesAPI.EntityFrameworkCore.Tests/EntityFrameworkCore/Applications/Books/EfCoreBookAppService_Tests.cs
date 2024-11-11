using KODCoursesAPI.Books;
using Xunit;

namespace KODCoursesAPI.EntityFrameworkCore.Applications.Books;

[Collection(KODCoursesAPITestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<KODCoursesAPIEntityFrameworkCoreTestModule>
{

}