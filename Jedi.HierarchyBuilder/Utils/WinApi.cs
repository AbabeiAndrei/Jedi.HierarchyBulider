using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class WinApi
    {
        #region Constants

        private const string EXPLORE_THEME = "explorer";

        #endregion

        #region PInvokes

        [DllImport("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hWnd, 
                                                 [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName,
                                                 [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList);

        #endregion

        #region Public methods

        public static void SetExplorerTheme(Control control)
        {
            if (control == null)
                return;

            if (Environment.OSVersion.Version.Major >= 6 &&             //explorer theme is available only for Vista+
                Environment.OSVersion.Platform == PlatformID.Win32NT    //and available only for NT (for example CE or RT will not work)
            ) 
            {
                SetWindowTheme(control.Handle, EXPLORE_THEME, null);
            }
        }

        #endregion
    }
}
