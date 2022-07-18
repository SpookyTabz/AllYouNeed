using AllYouNeed.Shell;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Hardware.IO
{
    public class FileSystem
    {
        private CosmosVFS fs;

        public FileSystem()
        {
            fs = new CosmosVFS();
            VFSManager.RegisterVFS(fs);
        }
    }
}
