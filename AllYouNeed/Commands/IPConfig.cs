using AllYouNeed.Core;
using AllYouNeed.Shell;
using Cosmos.HAL;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Commands
{
    public class IPConfig : Command
    {
        public IPConfig()
        {
            name = "IPConfig";
            description = "Lets you configure / show network";
            usage = new string[2] { "ipconfig", "ipc" };
        }

        public override void execute(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Error! type help ipconfig for commands");
                return;
            }

            string dns = "";

            switch (NetworkConfiguration.CurrentNetworkConfig.Device.CardType)
            {
                case CardType.Ethernet:
                    CLI.Write("Ethernet Card        : " + NetworkConfiguration.CurrentNetworkConfig.Device.NameID + " - " + NetworkConfiguration.CurrentNetworkConfig.Device.Name);
                    break;

                case CardType.Wireless:
                    CLI.Write("Wireless Card        : " + NetworkConfiguration.CurrentNetworkConfig.Device.NameID + " - " + NetworkConfiguration.CurrentNetworkConfig.Device.Name);
                    break;
            }
            CLI.Write("\n");

            CLI.WriteLine("MAC Address          : " + NetworkConfiguration.CurrentNetworkConfig.Device.MACAddress.ToString());
            CLI.WriteLine("IP Address           : " + NetworkConfiguration.CurrentNetworkConfig.IPConfig.IPAddress.ToString());
            CLI.WriteLine("Subnet mask          : " + NetworkConfiguration.CurrentNetworkConfig.IPConfig.SubnetMask.ToString());
            CLI.WriteLine("Default Gateway      : " + NetworkConfiguration.CurrentNetworkConfig.IPConfig.DefaultGateway.ToString());

            foreach (Address dns1 in DNSConfig.DNSNameservers)
            {
                dns = dns1.ToString();
            }

            CLI.WriteLine("DNS Nameserver       : " + dns);

            base.execute(args);
        }
    }
}
