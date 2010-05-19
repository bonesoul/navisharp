using System;

using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace ceExplorerPatch
{
    public enum FileSystemItemType
    {
        FILE,
        FOLDER
    }

    public static class FileSystem
    {
        public static string CurrentPath;

        public static void Navigate(string path)
        {
            CurrentPath = path+"\\";
        }

        public static ArrayList GetFolders()
        {
            ArrayList folders = new ArrayList();
            DirectoryInfo dir = new DirectoryInfo(CurrentPath);
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                folders.Add(d.Name);
            }
            return folders;
        }

        public static ArrayList GetFiles()
        {
            ArrayList files = new ArrayList();
            DirectoryInfo dir = new DirectoryInfo(CurrentPath);
            foreach (FileInfo f in dir.GetFiles())
            {
                files.Add(f.Name);
            }
            return files;
        }

        public static void Execute(string Path)
        {
            System.Diagnostics.Process.Start(Path, "");
        }

        public static FileSystemItemType CheckItemType(string path)
        {
            if (Directory.Exists(path)) return FileSystemItemType.FOLDER;
            else return FileSystemItemType.FILE;
        }

        public static bool CheckFile(string Path)
        {
            return File.Exists(Path);
        }
    }
}
