using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NaviLib
{
    public static class FileSystem
    {
        public static void Run(string ExecutablePath)
        {
            Process.Start(ExecutablePath, "");
        }
    }
}
