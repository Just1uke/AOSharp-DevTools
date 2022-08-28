using System;
using System.Runtime.InteropServices;
using AOSharp.Common.Unmanaged.Imports;

namespace DevTools.Unmanaged.GUI
{
    class SceneBase_t
    {
        [DllImport("GUI.dll", EntryPoint = "?DisableDebugTextArea@SceneBase_t@@QAEXXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr DisableDebugTextArea(IntPtr pThis);

        [DllImport("GUI.dll", EntryPoint = "?EnableDebugTextArea@SceneBase_t@@QAEXXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr EnableDebugTextArea(IntPtr pThis);

        [DllImport("GUI.dll", EntryPoint = "?UpdateDebugTextArea@SceneBase_t@@QAEXABV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr UpdateDebugTextArea(IntPtr pThis);

        public static IntPtr CurrentScene = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("GUI.dll"), "?m_pcCurrentScene@SceneBase_t@@1PAV1@A") + 0x18;


    }
}
