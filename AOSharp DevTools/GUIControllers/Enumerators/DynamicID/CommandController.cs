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
    public class CommandController : DynamicIDController
    {

        public CommandController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings, DynamicIdDisplayType.Text, "Command", "COMMAND_", 0, 214)
        {
            //Chat.WriteLine(MIN_VALUE);
            //Chat.WriteLine(MAX_VALUE);
        }
    }

}
