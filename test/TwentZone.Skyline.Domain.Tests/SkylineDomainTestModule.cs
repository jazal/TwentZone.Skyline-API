using Volo.Abp.Modularity;

namespace TwentZone.Skyline;

[DependsOn(
    typeof(SkylineDomainModule),
    typeof(SkylineTestBaseModule)
)]
public class SkylineDomainTestModule : AbpModule
{

}
