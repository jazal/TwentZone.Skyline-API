using Volo.Abp.Modularity;

namespace TwentZone.Skyline;

/* Inherit from this class for your domain layer tests. */
public abstract class SkylineDomainTestBase<TStartupModule> : SkylineTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
