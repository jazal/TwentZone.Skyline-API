using System;
using System.Collections.Generic;
using System.Text;
using TwentZone.Skyline.Localization;
using Volo.Abp.Application.Services;

namespace TwentZone.Skyline;

/* Inherit your application services from this class.
 */
public abstract class SkylineAppService : ApplicationService
{
    protected SkylineAppService()
    {
        LocalizationResource = typeof(SkylineResource);
    }
}
