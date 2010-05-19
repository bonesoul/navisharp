using System;

using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace ceExplorerPatch
{
    public enum KEY_ROOT
    {
        HKEY_CLASSES_ROOT,
        HKEY_CURRENT_USER,
        HKEY_LOCAL_MACHINE
    }

    public static class Registry
    {
        public static RegistryKey GetKey(KEY_ROOT root, string _key)
        {
            RegistryKey rootkey;
            switch (root)
            {
                case KEY_ROOT.HKEY_CLASSES_ROOT:
                    rootkey = Microsoft.Win32.Registry.ClassesRoot;
                    break;
                case KEY_ROOT.HKEY_CURRENT_USER:
                    rootkey = Microsoft.Win32.Registry.CurrentUser;
                    break;
                case KEY_ROOT.HKEY_LOCAL_MACHINE:
                    rootkey = Microsoft.Win32.Registry.LocalMachine;
                    break;
                default:
                    rootkey = Microsoft.Win32.Registry.CurrentUser;
                    break;
            }
            return rootkey.OpenSubKey(_key,true);
        }
        
        public static bool CheckKey(KEY_ROOT root, string _key)
        {
            bool exists = false;
            RegistryKey key=GetKey(root, _key);
            if (key != null) exists = true;
            key.Close();
            key.Flush();
            return exists;
        }

        public static object GetValue(KEY_ROOT root, string _key, string _name)
        {
            RegistryKey key = GetKey(root, _key);
            object value = key.GetValue(_name);
            key.Close();
            key.Flush();
            return value;
        } 

        public static void SetValue(KEY_ROOT root, string _key, string _name,object _value)
        {
            RegistryKey key = GetKey(root, _key);
            key.SetValue(_name, _value);
            key.Close();
            key.Flush();
        }
    }
}
