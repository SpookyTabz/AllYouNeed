using AllYouNeed.Hardware.IO;
using AllYouNeed.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Core.Sequence
{
    public class Boot
    {
        public static Network network;
        public static FileSystem fs;

        private static int frames = 0;
        public static float delta { get; private set; } = 0;
        private static int tick = 0;

        public static void Initialize()
        {
            network = new Network();
            fs = new FileSystem();
        }

        public static void run()
        {
            CLI.getInput();
        }

        public void Process(String name, String errorMsg)
        {
            try
            {
                CLI.Write("[");
                CLI.Write("  OK  ", ConsoleColor.Green);
                CLI.Write("] " + name);
                CLI.Write("\n");
            }
            catch (Exception e)
            {
                CLI.Write("[");
                CLI.Write("  FAILED  ", ConsoleColor.Red);
                CLI.Write("] " + name);
                CLI.Write("INFO: " + errorMsg + (e.ToString()));
                CLI.Write("\n");
            }
        }
    }
}
