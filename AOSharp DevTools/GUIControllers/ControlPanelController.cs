using AOSharp.Common.GameData;
using AOSharp.Core.UI;
using AOSharp.Core;
using AOSharp.Common.GameData.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevTools.GUIControllers
{
    public class ControlPanelController : Controller
    {
        //private int curSliderValue = 0;
        public ControlPanelController(String PluginDirectory, AOSharp.Core.Settings PluginSettings)  : base(PluginDirectory, PluginSettings){ }

        public override void RegisterControllerCallbacks()
        {
            base.RegisterControllerCallbacks();
            Controller.AllControllersLoaded += OpenIfConfigured;
        }

        public override void RegisterCommands()
        {
            base.RegisterCommands();

            Chat.RegisterCommand("devtools", (string command, string[] param, ChatWindow chatWindow) =>
            {
                try
                {
                    InitializeWindow();
                    if (PluginUI.IsVisible)
                    {
                        PluginUI.Close();
                    } else
                    {
                        PluginUI.Show(true);
                    }
                }
                catch (Exception e)
                {
                    Chat.WriteLine(e);
                }
            });
        }


        public override bool InitializeWindow(bool AutoOpen)
        {
            if(base.InitializeWindow(PluginDirectory + "\\UI\\ControlPanel.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - Control Panel",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade, 
                autoOpen: AutoOpen))
            {
                return true;
            } else
            {
                return false;
            }
        }



        private void OpenIfConfigured(object sender, EventArgs e)
        {
            if (PluginSettings["OpenControlPanelOnInject"].AsBool())
            {
                if (InitializeWindow() && PluginUI != null && PluginUI.IsValid)
                {
                    PluginUI.Show(true);
                }
                else
                {
                    Chat.WriteLine("Failed to initialize control panel.", ChatColor.Red);
                }
            }
        }

        public override void CheckForClickedButtons()
        {
            try
            {
                if (PluginUI != null && PluginUI.IsValid)
                {

                    PluginUI.Views.ForEach(delegate (View UIView)
                    {
                        if(UIView != null)
                        {
                            if (UIView.FindChild("Open_Options", out Button btnOpenOptions))
                            {
                                btnOpenOptions.Tag = UIView;
                                btnOpenOptions.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("OptionsController"); }; // Open a new "Options" window.
                            }
                            if (UIView.FindChild("Open_About", out Button btnOpenAbout))
                            {
                                btnOpenAbout.Tag = UIView;
                                btnOpenAbout.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("AboutController"); }; // Open a new "About" window.
                            }
                            if (UIView.FindChild("Open_Help", out Button btnOpenHelp))
                            {
                                btnOpenHelp.Tag = UIView;
                                btnOpenHelp.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("HelpController"); }; // Open a new "Help" window.
                            }
                            if (UIView.FindChild("Open_Modules", out Button btnOpenModules))
                            {
                                btnOpenModules.Tag = UIView;
                                btnOpenModules.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("ModulesController"); }; // Open a new "Modules" window.
                            }
                            if (UIView.FindChild("Open_Events", out Button btnOpenEvents))
                            {
                                btnOpenEvents.Tag = UIView;
                                btnOpenEvents.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("EventsController"); }; // Open a new "Events" window.
                            }
                            if (UIView.FindChild("Open_Enumerators", out Button btnOpenEnumerators))
                            {
                                btnOpenEnumerators.Tag = UIView;
                                btnOpenEnumerators.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("EnumeratorsController"); }; // Open a new "Enumerators" window.
                            }

                            // Custom run actions, mostly used for the quick testing of things
                            if (UIView.FindChild("Run_Action1", out Button btnAction1))
                            {
                                btnAction1.Tag = UIView;
                                btnAction1.Clicked = (object s, ButtonBase button) => {
                                    
                                };
                            }
                            if (UIView.FindChild("Run_Action2", out Button btnAction2))
                            {
                                btnAction2.Tag = UIView;
                                btnAction2.Clicked = (object s, ButtonBase button) => {
                                    
                                };
                            }
                            if (UIView.FindChild("Run_Action3", out Button btnAction3))
                            {
                                btnAction3.Tag = UIView;
                                btnAction3.Clicked = (object s, ButtonBase button) => {
                                    Chat.WriteLine("Use this button for testing your own stuff!");
                                };
                            }
                            if (UIView.FindChild("Run_Action4", out Button btnAction4))
                            {
                                btnAction4.Tag = UIView;
                                btnAction4.Clicked = (object s, ButtonBase button) => {
                                    Chat.WriteLine("Use this button for testing your own stuff!");
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



/*
 * 
 * 
 * 
 * 
/* private: static void __cdecl ControlCenterModule_c::OpenServerStatWindowMessage(void)
void __cdecl ControlCenterModule_c::OpenServerStatWindowMessage(void)
 */