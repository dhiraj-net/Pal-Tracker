using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/env")]
    public class EnvController:ControllerBase
    {
        private readonly CloudFoundryInfo _envInfo;

        [HttpGet]
        public CloudFoundryInfo Get() => _envInfo;

        public EnvController(CloudFoundryInfo info)
        {
            _envInfo = info;
        }

    }
}