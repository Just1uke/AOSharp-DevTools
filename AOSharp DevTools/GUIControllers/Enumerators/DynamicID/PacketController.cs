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
    public class PacketController : DynamicIDController
    {
        public PacketController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings, DynamicIdDisplayType.Text, "Packet", "PACKET_", 0, 424)
        {

        }
    }
}
