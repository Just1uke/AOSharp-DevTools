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

//using DevTools.Unmanaged.Imports;

namespace DevTools.GUIControllers.Enumerators.DynamicID
{
    public class GFXController : DynamicIDController
    {
        public GFXController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings, DynamicIdDisplayType.Bitmap, "Graphics", "GFX_", 0, 796)
        {
        }
    }

}
