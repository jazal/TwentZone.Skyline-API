using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TwentZone.Skyline;

[Dependency(ReplaceServices = true)]
public class SkylineBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Skyline";
}
