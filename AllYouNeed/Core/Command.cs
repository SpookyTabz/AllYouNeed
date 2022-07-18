using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Core
{
    public class Command
    {
        public string name;
        public string description;
        public string[] usage;

        public virtual void execute(string[] args) {}
    }
}
