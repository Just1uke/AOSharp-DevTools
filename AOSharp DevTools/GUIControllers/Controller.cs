using AOSharp.Common.GameData;
using AOSharp.Core.UI;
using AOSharp.Core;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOSharp.Common.GameData.UI;

namespace DevTools
{
    public class Controller
    {
        public static EventHandler AllControllersLoaded;
        public static EventHandler Teardown;
        public EventHandler Registered;

        public String name { get => this.GetType().Name; }

        public static string PluginDirectory;
        public static AOSharp.Core.Settings PluginSettings;
        public Window PluginUI;

        public Controller(String PluginDirectory, AOSharp.Core.Settings PluginSettings)
        {
            Controller.PluginDirectory = PluginDirectory;
            Controller.PluginSettings = PluginSettings;
        }

        public virtual void RegisterCommands(){}

        public virtual void RegisterControllerCallbacks()
        {
            Game.OnUpdate += OnUpdate;
        }

        public virtual void RegisterGlobalVariables() { }

        private void OnUpdate(object sender, float deltaTime)
        {
            try
            {
                CheckForClickedButtons();
            }
            catch (Exception e)
            {
                Chat.WriteLine(e);
            }
        }

        public virtual void CheckForClickedButtons() { }

        public virtual bool InitializeWindow() {
            return InitializeWindow(false);
        }

        public virtual bool InitializeWindow(bool AutoOpen)
        {
            return false;
        }

        public virtual bool Open()
        {
            return InitializeWindow(true);
        }

        public bool InitializeWindow(string XMLPath, Rect windowSize, string windowName="", WindowStyle windowStyle = WindowStyle.Default, WindowFlags windowFlags = WindowFlags.AutoScale, bool autoOpen=false)
        {
            if (PluginUI == null || !PluginUI.IsValid)
            {
                if (File.Exists(XMLPath))
                {
                    PluginUI = Window.CreateFromXml(windowName, XMLPath,
                    windowSize: windowSize,
                    windowStyle: windowStyle,
                    windowFlags: windowFlags);
                } else
                {
                    Chat.WriteLine($"WARNING: The file \"{XMLPath}\" does not exist. Do not expect full functionality.");
                    return false;
                }
            }

            if (PluginUI.IsValid)
            {
                try
                {
                    if (autoOpen)
                    {
                        PluginUI.Show(true);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}