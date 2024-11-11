using KODCoursesAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace KODCoursesAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class KODCoursesAPIController : AbpControllerBase
{
    protected KODCoursesAPIController()
    {
        LocalizationResource = typeof(KODCoursesAPIResource);
    }
}
