using Volo.Abp.Modularity;

namespace TwentZone.Skyline;

[DependsOn(
    typeof(SkylineApplicationModule),
    typeof(SkylineDomainTestModule)
)]
public class SkylineApplicationTestModule : AbpModule
{

}
