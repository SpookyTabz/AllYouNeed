using AllYouNeed.Shell;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace AllYouNeed.Core.Sequence
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            CLI.Initialize();
            Boot.Initialize();
        }

        protected override void Run()
        {
            Clock.Update();
            Boot.run();
        }
    }
}
