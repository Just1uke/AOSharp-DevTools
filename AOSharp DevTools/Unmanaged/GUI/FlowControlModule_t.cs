using System;
using System.Runtime.InteropServices;

namespace DevTools.Unmanaged.GUI
{
    class FlowControlModule_t
    {
        [DllImport("GUI.dll", EntryPoint = "?DebugCrashAnarchyMessage1@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugCrashAnarchyMessage1();

        [DllImport("GUI.dll", EntryPoint = "?DebugCrashAnarchyMessage2@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugCrashAnarchyMessage2();

        [DllImport("GUI.dll", EntryPoint = "?DebugCrashAnarchyMessage3@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugCrashAnarchyMessage3();

        [DllImport("GUI.dll", EntryPoint = "?DebugCrashAnarchyMessage4@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugCrashAnarchyMessage4();

        [DllImport("GUI.dll", EntryPoint = "?DebugDisplayAllProgramsMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugDisplayAllProgramsMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugDisplayInfoMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugDisplayInfoMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugDisplayRunningProgramsMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugDisplayRunningProgramsMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugFramerateToggleMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugFramerateToggleMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugFrustum@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugFrustum();

        [DllImport("GUI.dll", EntryPoint = "?DebugInputModeMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugInputModeMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugLoadTweakValues@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugLoadTweakValues();

        [DllImport("GUI.dll", EntryPoint = "?DebugMemoryToggleMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugMemoryToggleMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugMouseWorldPosMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugMouseWorldPosMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugNextPageInfoMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugNextPageInfoMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugPosToChatExtMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugPosToChatExtMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugPosToChatMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugPosToChatMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugPrevPageInfoMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugPrevPageInfoMessage();

        [DllImport("GUI.dll", EntryPoint = "?DebugRender@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugRender();

        [DllImport("GUI.dll", EntryPoint = "?DebugRender_BVolume@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugRender_BVolume();

        [DllImport("GUI.dll", EntryPoint = "?DebugRender_Edge@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugRender_Edge();

        [DllImport("GUI.dll", EntryPoint = "?DebugRender_PrimCount@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugRender_PrimCount();

        [DllImport("GUI.dll", EntryPoint = "?DebugRender_Vertex@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugRender_Vertex();

        [DllImport("GUI.dll", EntryPoint = "?DebugReportBugMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DebugReportBugMessage();

        [DllImport("GUI.dll", EntryPoint = "?GmLevelChangedMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GMLevelChangedMessage();


    }
}
