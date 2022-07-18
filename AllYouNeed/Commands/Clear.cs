using AllYouNeed.Core;
using AllYouNeed.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Commands
{
    public class Clear : Command
    {
        public Clear()
        {
            name = "Clear";
            description = "Clears this terminal";
            usage = new string[3] { "cls", "clear", "clr" };
        }

        public override void execute(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Error! type help for commands");
                return;
            }

            CLI.Clear();
            base.execute(args);
        }
    }
}
