using AOSharp.Common.GameData;
using AOSharp.Core.UI;
using AOSharp.Core;
using AOSharp.Common.GameData.UI;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.GUIControllers
{

    public class OptionsController : Controller
    {
        public OptionsController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings){}

        public override void RegisterGlobalVariables()
        {
            base.RegisterGlobalVariables();
            PluginSettings.AddVariable("OpenControlPanelOnInject", false);
        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            if (base.InitializeWindow(PluginDirectory + "\\UI\\Options.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - Options",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
                autoOpen: AutoOpen))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}