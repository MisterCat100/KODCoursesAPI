using KODCoursesAPI.Localization;
using Volo.Abp.Application.Services;

namespace KODCoursesAPI;

/* Inherit your application services from this class.
 */
public abstract class KODCoursesAPIAppService : ApplicationService
{
    protected KODCoursesAPIAppService()
    {
        LocalizationResource = typeof(KODCoursesAPIResource);
    }
}
