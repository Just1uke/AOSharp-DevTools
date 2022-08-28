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
using System.Reflection;

namespace DevTools.GUIControllers
{
    public class VisualEnvFX_tController : Controller
    {
        public VisualEnvFX_tController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
        {

        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            return base.InitializeWindow(PluginDirectory + "\\UI\\Modules\\VisualEnvFX_t.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - VisualEnvFX_t",
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

                            if (UIView.FindChild("VisualEnvFX_t::ToggleOcclusionCulling()", out AOSharp.Core.UI.Button toggleOcclusionCulling))
                            {
                                toggleOcclusionCulling.Tag = UIView;
                                toggleOcclusionCulling.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleOcclusionCulling() = {VisualEnvFX_t.ToggleOcclusionCulling(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerDepthDisplay()", out AOSharp.Core.UI.Button toggleRandyDebuggerDepthDisplay))
                            {
                                toggleRandyDebuggerDepthDisplay.Tag = UIView;
                                toggleRandyDebuggerDepthDisplay.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerDepthDisplay() = {VisualEnvFX_t.ToggleRandyDebuggerDepthDisplay(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerDoNotRender()", out AOSharp.Core.UI.Button toggleRandyDebuggerDoNotRender))
                            {
                                toggleRandyDebuggerDoNotRender.Tag = UIView;
                                toggleRandyDebuggerDoNotRender.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerDoNotRender() = {VisualEnvFX_t.ToggleRandyDebuggerDoNotRender(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerKDTreeDisplay()", out AOSharp.Core.UI.Button toggleRandyDebuggerKDTreeDisplay))
                            {
                                toggleRandyDebuggerKDTreeDisplay.Tag = UIView;
                                toggleRandyDebuggerKDTreeDisplay.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerKDTreeDisplay() = {VisualEnvFX_t.ToggleRandyDebuggerKDTreeDisplay(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerOcclusionBodies()", out AOSharp.Core.UI.Button toggleRandyDebuggerOcclusionBodies))
                            {
                                toggleRandyDebuggerOcclusionBodies.Tag = UIView;
                                toggleRandyDebuggerOcclusionBodies.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerOcclusionBodies() = {VisualEnvFX_t.ToggleRandyDebuggerOcclusionBodies(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerOcclusionScan()", out AOSharp.Core.UI.Button toggleRandyDebuggerOcclusionScan))
                            {
                                toggleRandyDebuggerOcclusionScan.Tag = UIView;
                                toggleRandyDebuggerOcclusionScan.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerOcclusionScan() = {VisualEnvFX_t.ToggleRandyDebuggerOcclusionScan(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerOcclusionTest()", out AOSharp.Core.UI.Button toggleRandyDebuggerOcclusionTest))
                            {
                                toggleRandyDebuggerOcclusionTest.Tag = UIView;
                                toggleRandyDebuggerOcclusionTest.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerOcclusionTest() = {VisualEnvFX_t.ToggleRandyDebuggerOcclusionTest(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerOffscreenDisplay()", out AOSharp.Core.UI.Button toggleRandyDebuggerOffscreenDisplay))
                            {
                                toggleRandyDebuggerOffscreenDisplay.Tag = UIView;
                                toggleRandyDebuggerOffscreenDisplay.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerOffscreenDisplay() = {VisualEnvFX_t.ToggleRandyDebuggerOffscreenDisplay(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerRefractionDisplay()", out AOSharp.Core.UI.Button toggleRandyDebuggerRefractionDisplay))
                            {
                                toggleRandyDebuggerRefractionDisplay.Tag = UIView;
                                toggleRandyDebuggerRefractionDisplay.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerRefractionDisplay() = {VisualEnvFX_t.ToggleRandyDebuggerRefractionDisplay(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowCATWireframe()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowCATWireframe))
                            {
                                toggleRandyDebuggerShowCATWireframe.Tag = UIView;
                                toggleRandyDebuggerShowCATWireframe.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowCATWireframe() = {VisualEnvFX_t.ToggleRandyDebuggerShowCATWireframe(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowGroundWireframe()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowGroundWireframe))
                            {
                                toggleRandyDebuggerShowGroundWireframe.Tag = UIView;
                                toggleRandyDebuggerShowGroundWireframe.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowGroundWireframe() = {VisualEnvFX_t.ToggleRandyDebuggerShowGroundWireframe(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowLiquidWireframe()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowLiquidWireframe))
                            {
                                toggleRandyDebuggerShowLiquidWireframe.Tag = UIView;
                                toggleRandyDebuggerShowLiquidWireframe.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowLiquidWireframe() = {VisualEnvFX_t.ToggleRandyDebuggerShowLiquidWireframe(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowMouseFix()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowMouseFix))
                            {
                                toggleRandyDebuggerShowMouseFix.Tag = UIView;
                                toggleRandyDebuggerShowMouseFix.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowMouseFix() = {VisualEnvFX_t.ToggleRandyDebuggerShowMouseFix(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowStatelWireframe()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowStatelWireframe))
                            {
                                toggleRandyDebuggerShowStatelWireframe.Tag = UIView;
                                toggleRandyDebuggerShowStatelWireframe.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowStatelWireframe() = {VisualEnvFX_t.ToggleRandyDebuggerShowStatelWireframe(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerShowSurfaceSliding()", out AOSharp.Core.UI.Button toggleRandyDebuggerShowSurfaceSliding))
                            {
                                toggleRandyDebuggerShowSurfaceSliding.Tag = UIView;
                                toggleRandyDebuggerShowSurfaceSliding.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerShowSurfaceSliding() = {VisualEnvFX_t.ToggleRandyDebuggerShowSurfaceSliding(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerSphereTest()", out AOSharp.Core.UI.Button toggleRandyDebuggerSphereTest))
                            {
                                toggleRandyDebuggerSphereTest.Tag = UIView;
                                toggleRandyDebuggerSphereTest.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerSphereTest() = {VisualEnvFX_t.ToggleRandyDebuggerSphereTest(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerSyncDisplay()", out AOSharp.Core.UI.Button toggleRandyDebuggerSyncDisplay))
                            {
                                toggleRandyDebuggerSyncDisplay.Tag = UIView;
                                toggleRandyDebuggerSyncDisplay.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerSyncDisplay() = {VisualEnvFX_t.ToggleRandyDebuggerSyncDisplay(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerToggleCapOffscreen()", out AOSharp.Core.UI.Button toggleRandyDebuggerToggleCapOffscreen))
                            {
                                toggleRandyDebuggerToggleCapOffscreen.Tag = UIView;
                                toggleRandyDebuggerToggleCapOffscreen.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerToggleCapOffscreen() = {VisualEnvFX_t.ToggleRandyDebuggerToggleCapOffscreen(VisualEnvFX_t.GetInstance())}");
                                };
                            }
                            if (UIView.FindChild("VisualEnvFX_t::ToggleRandyDebuggerToggleCapRefraction()", out AOSharp.Core.UI.Button toggleRandyDebuggerToggleCapRefraction))
                            {
                                toggleRandyDebuggerToggleCapRefraction.Tag = UIView;
                                toggleRandyDebuggerToggleCapRefraction.Clicked = (object s, ButtonBase button) =>
                                {
                                    Chat.WriteLine($"VisualEnvFX_t::ToggleRandyDebuggerToggleCapRefraction() = {VisualEnvFX_t.ToggleRandyDebuggerToggleCapRefraction(VisualEnvFX_t.GetInstance())}");
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
