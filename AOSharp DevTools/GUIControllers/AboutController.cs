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
    public class AboutController : Controller
    {
        public AboutController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
        {
            
        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            return base.InitializeWindow(PluginDirectory + "\\UI\\About.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - About",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
                autoOpen: AutoOpen);
        }
    }
}
