using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace NaviLib
{
    public static class Screen
    {
        public static Size GetScreenDimensions()
        {
            return System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        }

        public static Size GetWorkingArea()
        {
            return System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
