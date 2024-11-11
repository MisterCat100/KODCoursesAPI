using Microsoft.Extensions.Localization;
using KODCoursesAPI.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace KODCoursesAPI;

[Dependency(ReplaceServices = true)]
public class KODCoursesAPIBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<KODCoursesAPIResource> _localizer;

    public KODCoursesAPIBrandingProvider(IStringLocalizer<KODCoursesAPIResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
