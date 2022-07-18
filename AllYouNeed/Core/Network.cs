using AllYouNeed.Shell;
using Cosmos.HAL;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;

namespace AllYouNeed.Core
{
    public class Network
    {
        public static DHCPClient client;

        public Network()
        {
            client = new DHCPClient();
            client.SendDiscoverPacket();
        }

        public static DHCPClient getClient()
        {
            return client;
        }
    }
}
