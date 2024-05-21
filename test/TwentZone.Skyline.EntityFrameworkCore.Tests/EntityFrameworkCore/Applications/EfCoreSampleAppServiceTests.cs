using TwentZone.Skyline.Samples;
using Xunit;

namespace TwentZone.Skyline.EntityFrameworkCore.Applications;

[Collection(SkylineTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SkylineEntityFrameworkCoreTestModule>
{

}
