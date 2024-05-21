using TwentZone.Skyline.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TwentZone.Skyline.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SkylineController : AbpControllerBase
{
    protected SkylineController()
    {
        LocalizationResource = typeof(SkylineResource);
    }
}
