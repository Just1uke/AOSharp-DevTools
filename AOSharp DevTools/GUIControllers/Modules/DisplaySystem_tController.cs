using AOSharp.Common.GameData;
using AOSharp.Core.UI;
using AOSharp.Core;
using AOSharp.Common.GameData.UI;
using AOSharp.Common.Unmanaged.Imports;
using AOSharp.Common.Helpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevTools.Unmanaged.GUI;

namespace DevTools.GUIControllers
{
    unsafe public class DisplaySystem_tController : Controller
    {
        public DisplaySystem_tController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
        {

        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            return base.InitializeWindow(PluginDirectory + "\\UI\\Modules\\DisplaySystem_t.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - DisplaySystem_t",
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
                            if (UIView.FindChild("DisplaySystem_t::GetDebugInfo()", out AOSharp.Core.UI.Button displaySystemGetDebugInfoButton))
                            {
                                displaySystemGetDebugInfoButton.Tag = UIView;
                                displaySystemGetDebugInfoButton.Clicked = (object s, ButtonBase button) => {
                                    Chat.WriteLine($"DisplaySystem_t::GetDebugInfo():\n{Utils.UnsafePointerToString(DevTools.Unmanaged.GUI.DisplaySystem_t.GetDebugInfo(DevTools.Unmanaged.GUI.DisplaySystem_t.GetInstance()))}");
                                };
                            }
                            // Decrease Debug Page
                            if (UIView.FindChild("DisplaySystem_t::ChangeDebugPage(0)", out AOSharp.Core.UI.Button displaySystemChangeDebugPageDecrease))
                            {
                                displaySystemChangeDebugPageDecrease.Tag = UIView;
                                displaySystemChangeDebugPageDecrease.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.DisplaySystem_t.ChangeDebugPage(DevTools.Unmanaged.GUI.DisplaySystem_t.GetInstance(), 0);
                                    Chat.WriteLine($"DisplaySystem_t::ChangeDebugPage(0) - Current page:  {*(IntPtr*)(DisplaySystem_t.GetInstance() + 0x80)}");
                                };
                            }
                            // Increase Debug Page
                            if (UIView.FindChild("DisplaySystem_t::ChangeDebugPage(1)", out AOSharp.Core.UI.Button displaySystemChangeDebugPageIncrease))
                            {
                                displaySystemChangeDebugPageIncrease.Tag = UIView;
                                displaySystemChangeDebugPageIncrease.Clicked = (object s, ButtonBase button) => {
                                    DevTools.Unmanaged.GUI.DisplaySystem_t.ChangeDebugPage(DevTools.Unmanaged.GUI.DisplaySystem_t.GetInstance(), 1);
                                    Chat.WriteLine($"DisplaySystem_t::ChangeDebugPage(1) - Current page:  {*(IntPtr*)(DisplaySystem_t.GetInstance() + 0x80)}");
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


