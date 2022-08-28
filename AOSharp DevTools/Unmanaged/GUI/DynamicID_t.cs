using AOSharp.Common.GameData;
using System;
using System.Runtime.InteropServices;

namespace DevTools.Unmanaged.GUI
{
    unsafe public class DynamicID_t
    {
        [DllImport("AFCM.dll", EntryPoint = "?GetInstance@DynamicID_t@@SAPAV1@XZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetInstance();

        [DllImport("AFCM.dll", EntryPoint = "?GetID@DynamicID_t@@QAEHPBD_N@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern int GetID(IntPtr pThis, [MarshalAs(UnmanagedType.LPStr)] string name, bool unk);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
        public delegate int DGetID(IntPtr pThis, [MarshalAs(UnmanagedType.LPStr)] string name, bool unk);


        [DllImport("AFCM.dll", EntryPoint = "?GetID@DynamicID_t@@QAEPBDPBDH@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern char* GetID(IntPtr pThis, [MarshalAs(UnmanagedType.LPStr)] string name, int unk);

    }
}
