using System.Threading.Tasks;

namespace TwentZone.Skyline.Data;

public interface ISkylineDbSchemaMigrator
{
    Task MigrateAsync();
}
