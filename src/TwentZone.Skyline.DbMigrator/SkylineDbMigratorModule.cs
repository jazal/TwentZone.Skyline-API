using TwentZone.Skyline.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TwentZone.Skyline.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SkylineEntityFrameworkCoreModule),
    typeof(SkylineApplicationContractsModule)
    )]
public class SkylineDbMigratorModule : AbpModule
{
}
