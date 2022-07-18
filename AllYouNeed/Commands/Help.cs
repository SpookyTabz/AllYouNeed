using AllYouNeed.Core;
using AllYouNeed.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Commands
{
    public class Help : Command
    {
        public Help()
        {
            name = "Help";
            description = "Shows all the commands with description";
            usage = new string[2] { "help", "h" };
        }

        public override void execute(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Error! type help for commands");
                return;
            }

            CLI.Write("-----------------------------\n");

            foreach (Command cmd in CLI.commands)
            {
                CLI.WriteLine(cmd.name.ToUpper() + "  -  " + cmd.description);
            }

            CLI.Write("-----------------------------\n");
            base.execute(args);
        }
    }
}
