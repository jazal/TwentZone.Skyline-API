using Xunit;

namespace TwentZone.Skyline.EntityFrameworkCore;

[CollectionDefinition(SkylineTestConsts.CollectionDefinitionName)]
public class SkylineEntityFrameworkCoreCollection : ICollectionFixture<SkylineEntityFrameworkCoreFixture>
{

}
