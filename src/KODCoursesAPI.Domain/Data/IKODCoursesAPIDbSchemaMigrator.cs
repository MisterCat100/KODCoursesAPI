using System.Threading.Tasks;

namespace KODCoursesAPI.Data;

public interface IKODCoursesAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
