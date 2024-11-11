using KODCoursesAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace KODCoursesAPI.Permissions;

public class KODCoursesAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(KODCoursesAPIPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(KODCoursesAPIPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(KODCoursesAPIPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(KODCoursesAPIPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(KODCoursesAPIPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(KODCoursesAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<KODCoursesAPIResource>(name);
    }
}
