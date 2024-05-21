using Volo.Abp.Modularity;

namespace TwentZone.Skyline;

public abstract class SkylineApplicationTestBase<TStartupModule> : SkylineTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
