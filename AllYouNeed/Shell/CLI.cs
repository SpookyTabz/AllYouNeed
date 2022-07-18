using AllYouNeed.Commands;
using AllYouNeed.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllYouNeed.Shell
{
    public class CLI
    {
        public static ConsoleColor backColor = ConsoleColor.Black;
        public static ConsoleColor foreColor = ConsoleColor.White;

        public static List<Command> commands = new List<Command>();

        public static void Initialize()
        {
            Console.Clear();
            //WriteLine("All You Need", ConsoleColor.Cyan);

            commands.Add(new Clear());
            commands.Add(new Help());
            commands.Add(new IPConfig());
        }

        public static void getInput()
        {
            Write("->");
            string input = Console.ReadLine();
            string com = input.Split(' ')[0];
            bool exec = false;

            foreach (Command cmd in commands)
            {
                for (int i = 0; i < cmd.usage.Length; i++)
                {
                    if (cmd.usage[i] == com.ToString().ToLower())
                    {
                        cmd.execute(input.Split(' '));
                        exec = true;
                    }
                }
            }

            if (!exec)
            {
                WriteLine("Invalid Command! Type help for commands");
            }

            getInput();
        }

        // write
        public static void WriteLine(string txt) { Console.WriteLine(txt); }
        public static void WriteLine(string txt, ConsoleColor fg) { Console.ForegroundColor = fg; Console.WriteLine(txt); Console.ForegroundColor = foreColor; }
        public static void WriteLine(char txt, ConsoleColor fg) { Console.ForegroundColor = fg; Console.WriteLine(txt); Console.ForegroundColor = foreColor; }
        public static void WriteLine(string txt, ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Write(txt);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
        }
        public static void Write(string txt) { Console.Write(txt); }
        public static void Write(string txt, ConsoleColor fg) { Console.ForegroundColor = fg; Console.Write(txt); Console.ForegroundColor = foreColor; }
        public static void Write(string txt, ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Write(txt);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
        }
        public static void Clear() { Console.Clear(); }
        public static void Clear(ConsoleColor c) { backColor = c; Console.BackgroundColor = backColor; Console.Clear(); }

        // read
        public static int Read() { return Console.Read(); }
        public static string ReadLine() { return Console.ReadLine(); }

        // colors
        public static void SetFG(ConsoleColor fg) { foreColor = fg; }
        public static void SetBG(ConsoleColor bg) { backColor = bg; }

        public static void WaitNS(int ns) { Cosmos.HAL.Global.PIT.Wait((uint)ns); }
        public static void WaitMS(int ms) { Cosmos.HAL.Global.PIT.Wait((uint)ms); }
        public static void Wait(int secs) { for (int i = 0; i < secs; i++) { WaitMS(1000); } }
    }
}
