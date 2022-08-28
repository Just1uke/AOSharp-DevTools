using System;

using AOSharp.Core;
using AOSharp.Core.UI;
using AOSharp.Common.GameData;

using DevTools.GUIControllers;
using DevTools.GUIControllers.Enumerators.DynamicID;

namespace DevTools
{
    public class Main : AOPluginEntry
    {

        private static AOSharp.Core.Settings DevToolsSettings = new AOSharp.Core.Settings("DevTools");
        public static string PluginDirectory;

        public override void Run(string PluginDirectory)
        {

            try
            {
                DevToolsSettings.Load();
                Main.PluginDirectory = PluginDirectory;
                RegisterControllers();

                Chat.WriteLine("Developer tools loaded!");
                Chat.WriteLine("/devtools for settings.");

            }
            catch (Exception e)
            {
                Chat.WriteLine($"Exception encountered: {e.Message}", ChatColor.Red);
            }
        }

        private void RegisterControllers()
        {   
            ControllerManager.controllers.Add(new ControlPanelController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new OptionsController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new EventsController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new HelpController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new AboutController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new ModulesController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new DisplaySystem_tController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new FlowControlModule_tController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new SceneBase_tController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new VisualEnvFX_tController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new EnumeratorsController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new CommandController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new DestinationController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new GFXController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new HotspotController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new KeyController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new PacketController(Main.PluginDirectory, Main.DevToolsSettings));
            ControllerManager.controllers.Add(new ProgramController(Main.PluginDirectory, Main.DevToolsSettings));

            Controller.AllControllersLoaded?.Invoke(null, null);
        }

        public override void Teardown()
        {
            Controller.Teardown?.Invoke(null, null);
            DevToolsSettings.Save();
        }



    }

}
