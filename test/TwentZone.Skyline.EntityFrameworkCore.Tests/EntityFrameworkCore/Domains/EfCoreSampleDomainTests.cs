using TwentZone.Skyline.Samples;
using Xunit;

namespace TwentZone.Skyline.EntityFrameworkCore.Domains;

[Collection(SkylineTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SkylineEntityFrameworkCoreTestModule>
{

}
