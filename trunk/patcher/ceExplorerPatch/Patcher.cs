using System;

using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ceExplorerPatch
{
    public static class Patcher
    {
        public static bool GotExplorerExe=false;
        public static bool GotInitKey = false;
        public static string Shell;

        public static bool Check()
        {
            if (FileSystem.CheckFile("\\windows\\explorer.exe")) GotExplorerExe = true;
            if (Registry.CheckKey(KEY_ROOT.HKEY_LOCAL_MACHINE, "init")) GotInitKey = true;
            {
                Shell = Registry.GetValue(KEY_ROOT.HKEY_LOCAL_MACHINE, "init", "Launch60").ToString();
            }

            if (GotExplorerExe && GotInitKey) return true;
            else return false;
        }

        public static void Patch()
        {
            Registry.SetValue(KEY_ROOT.HKEY_LOCAL_MACHINE, "init", "Launch60", "explorer.exe");
        }
    }
}
