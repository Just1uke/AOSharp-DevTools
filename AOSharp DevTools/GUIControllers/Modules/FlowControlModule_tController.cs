using AOSharp.Common.GameData;
using AOSharp.Core.UI;
using AOSharp.Core;
using AOSharp.Common.GameData.UI;
using AOSharp.Common.Unmanaged.Imports;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevTools.Unmanaged.GUI;

namespace DevTools.GUIControllers
{
    public class FlowControlModule_tController : Controller
    {
        public FlowControlModule_tController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
        {

        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            return base.InitializeWindow(PluginDirectory + "\\UI\\Modules\\FlowControlModule_t.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - FlowControlModule_t",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
                autoOpen: AutoOpen);
        }

        public override void CheckForClickedButtons()
        {
            try
            {
                if (PluginUI != null && PluginUI.IsValid)
                {

                    PluginUI.Views.ForEach(delegate (View UIView)
                    {
                        if (UIView != null)
                        {
                            if (UIView.FindChild("FlowControlModule_t::DebugCrashAnarchyMessage1()", out AOSharp.Core.UI.Button debugCrashAnarchyMessage1))
                            {
                                debugCrashAnarchyMessage1.Tag = UIView;
                                debugCrashAnarchyMessage1.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugCrashAnarchyMessage1();
                                    Chat.WriteLine("FlowControlModule_t::DebugCrashAnarchyMessage1()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugCrashAnarchyMessage2()", out AOSharp.Core.UI.Button debugCrashAnarchyMessage2))
                            {
                                debugCrashAnarchyMessage2.Tag = UIView;
                                debugCrashAnarchyMessage2.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugCrashAnarchyMessage2();
                                    Chat.WriteLine("FlowControlModule_t::DebugCrashAnarchyMessage2()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugCrashAnarchyMessage3()", out AOSharp.Core.UI.Button debugCrashAnarchyMessage3))
                            {
                                debugCrashAnarchyMessage3.Tag = UIView;
                                debugCrashAnarchyMessage3.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugCrashAnarchyMessage3();
                                    Chat.WriteLine("FlowControlModule_t::DebugCrashAnarchyMessage3()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugCrashAnarchyMessage4()", out AOSharp.Core.UI.Button debugCrashAnarchyMessage4))
                            {
                                debugCrashAnarchyMessage4.Tag = UIView;
                                debugCrashAnarchyMessage4.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugCrashAnarchyMessage4();
                                    Chat.WriteLine("FlowControlModule_t::DebugCrashAnarchyMessage4()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugDisplayAllProgramsMessage()", out AOSharp.Core.UI.Button debugDisplayAllProgramsMessage))
                            {
                                debugDisplayAllProgramsMessage.Tag = UIView;
                                debugDisplayAllProgramsMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugDisplayAllProgramsMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugDisplayAllProgramsMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugDisplayInfoMessage()", out AOSharp.Core.UI.Button debugDisplayInfoMessage))
                            {
                                debugDisplayInfoMessage.Tag = UIView;
                                debugDisplayInfoMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugDisplayInfoMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugDisplayInfoMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugDisplayRunningProgramsMessage()", out AOSharp.Core.UI.Button debugDisplayRunningProgramsMessage))
                            {
                                debugDisplayRunningProgramsMessage.Tag = UIView;
                                debugDisplayRunningProgramsMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugDisplayRunningProgramsMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugDisplayRunningProgramsMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugFramerateToggleMessage()", out AOSharp.Core.UI.Button debugFramerateToggleMessage))
                            {
                                debugFramerateToggleMessage.Tag = UIView;
                                debugFramerateToggleMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugFramerateToggleMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugFramerateToggleMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugFrustum()", out AOSharp.Core.UI.Button debugFrustum))
                            {
                                debugFrustum.Tag = UIView;
                                debugFrustum.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugFrustum();
                                    Chat.WriteLine("FlowControlModule_t::DebugFrustum()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugInputModeMessage()", out AOSharp.Core.UI.Button debugInputModeMessage))
                            {
                                debugInputModeMessage.Tag = UIView;
                                debugInputModeMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugInputModeMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugInputModeMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugLoadTweakValues()", out AOSharp.Core.UI.Button debugLoadTweakValues))
                            {
                                debugLoadTweakValues.Tag = UIView;
                                debugLoadTweakValues.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugLoadTweakValues();
                                    Chat.WriteLine("FlowControlModule_t::DebugLoadTweakValues()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugMemoryToggleMessage()", out AOSharp.Core.UI.Button debugMemoryToggleMessage))
                            {
                                debugMemoryToggleMessage.Tag = UIView;
                                debugMemoryToggleMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugMemoryToggleMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugMemoryToggleMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugMouseWorldPosMessage()", out AOSharp.Core.UI.Button debugMouseWorldPosMessage))
                            {
                                debugMouseWorldPosMessage.Tag = UIView;
                                debugMouseWorldPosMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugMouseWorldPosMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugMouseWorldPosMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugNextPageInfoMessage()", out AOSharp.Core.UI.Button debugNextPageInfoMessage))
                            {
                                debugNextPageInfoMessage.Tag = UIView;
                                debugNextPageInfoMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugNextPageInfoMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugNextPageInfoMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugPosToChatExtMessage()", out AOSharp.Core.UI.Button debugPosToChatExtMessage))
                            {
                                debugPosToChatExtMessage.Tag = UIView;
                                debugPosToChatExtMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugPosToChatExtMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugPosToChatExtMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugPosToChatMessage()", out AOSharp.Core.UI.Button debugPosToChatMessage))
                            {
                                debugPosToChatMessage.Tag = UIView;
                                debugPosToChatMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugPosToChatMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugPosToChatMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugPrevPageInfoMessage()", out AOSharp.Core.UI.Button debugPrevPageInfoMessage))
                            {
                                debugPrevPageInfoMessage.Tag = UIView;
                                debugPrevPageInfoMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugPrevPageInfoMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugPrevPageInfoMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugRender()", out AOSharp.Core.UI.Button debugRender))
                            {
                                debugRender.Tag = UIView;
                                debugRender.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugRender();
                                    Chat.WriteLine("FlowControlModule_t::DebugRender()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugRender_BVolume()", out AOSharp.Core.UI.Button debugRender_BVolume))
                            {
                                debugRender_BVolume.Tag = UIView;
                                debugRender_BVolume.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugRender_BVolume();
                                    Chat.WriteLine("FlowControlModule_t::DebugRender_BVolume()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugRender_Edge()", out AOSharp.Core.UI.Button debugRender_Edge))
                            {
                                debugRender_Edge.Tag = UIView;
                                debugRender_Edge.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugRender_Edge();
                                    Chat.WriteLine("FlowControlModule_t::DebugRender_Edge()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugRender_PrimCount()", out AOSharp.Core.UI.Button debugRender_PrimCount))
                            {
                                debugRender_PrimCount.Tag = UIView;
                                debugRender_PrimCount.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugRender_PrimCount();
                                    Chat.WriteLine("FlowControlModule_t::DebugRender_PrimCount()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugRender_Vertex()", out AOSharp.Core.UI.Button debugRender_Vertex))
                            {
                                debugRender_Vertex.Tag = UIView;
                                debugRender_Vertex.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugRender_Vertex();
                                    Chat.WriteLine("FlowControlModule_t::DebugRender_Vertex()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::DebugReportBugMessage()", out AOSharp.Core.UI.Button debugReportBugMessage))
                            {
                                debugReportBugMessage.Tag = UIView;
                                debugReportBugMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.DebugReportBugMessage();
                                    Chat.WriteLine("FlowControlModule_t::DebugReportBugMessage()");
                                };
                            }
                            if (UIView.FindChild("FlowControlModule_t::GmLevelChangedMessage()", out AOSharp.Core.UI.Button gmLevelChangedMessage))
                            {
                                gmLevelChangedMessage.Tag = UIView;
                                gmLevelChangedMessage.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.FlowControlModule_t.GMLevelChangedMessage();
                                    Chat.WriteLine("FlowControlModule_t::GMLevelChangedMessage()");
                                };
                            }


                        }
                    });
                }
            }
            catch (Exception e)
            {
                Chat.WriteLine(e);
            }
        }


    }
}
