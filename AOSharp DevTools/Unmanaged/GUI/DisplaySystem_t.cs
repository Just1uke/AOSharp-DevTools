using System;
using System.Runtime.InteropServices;
using AOSharp.Common.Unmanaged.Imports;

namespace DevTools.Unmanaged.GUI
{
    unsafe class DisplaySystem_t
    {



        [DllImport("DisplaySystem.dll", EntryPoint = "?GetDebugInfo@DisplaySystem_t@@QAEPBDXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr GetDebugInfo(IntPtr pThis);

        [DllImport("DisplaySystem.dll", EntryPoint = "?ChangeDebugPage@DisplaySystem_t@@QAEXH@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr ChangeDebugPage(IntPtr pThis, int page);

        [DllImport("DisplaySystem.dll", EntryPoint = "?GetInstance@DisplaySystem_t@@SAPAV1@XZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetInstance();
    }
}
