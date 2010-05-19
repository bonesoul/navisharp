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
            return rootkey.OpenSubKey(_key);
        }
        
        public static bool CheckKey(KEY_ROOT root, string _key)
        {
            RegistryKey key=GetKey(root, _key);
            if (key == null)
                return false;
            else
                return true;
        }

        public static object GetValue(KEY_ROOT root, string _key, string _value)
        {
            RegistryKey key = GetKey(root, _key);
            return key.GetValue(_value);
        } 

        public static void SetValue(KEY_ROOT root, string _key, string _name,object _value)
        {
            RegistryKey key = GetKey(root, _key);
            key.SetValue(_name, _value);
        }
    }
}
