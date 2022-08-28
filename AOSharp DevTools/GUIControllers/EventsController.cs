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

//using DevTools.Unmanaged.Imports;

namespace DevTools.GUIControllers
{
	public class EventsController : Controller
	{
		public EventsController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
		{

		}

		public override bool InitializeWindow(bool AutoOpen)
		{
			return base.InitializeWindow(PluginDirectory + "\\UI\\Events.xml", new Rect(0, 0, 455, 345),
				windowName: "Developer Tools - Events",
				windowStyle: WindowStyle.Default,
				windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
				autoOpen: AutoOpen);
		}

		public override void RegisterGlobalVariables()
		{
			base.RegisterGlobalVariables();
			PluginSettings.AddVariable("PrintInboundPackets", false);
			PluginSettings.AddVariable("PrintOutboundPackets", false);
		}

		public override void RegisterControllerCallbacks()
		{
			base.RegisterControllerCallbacks();
			Network.PacketReceived += NetworkPacketReceived;
			Network.PacketSent += NetworkPacketSent;
		}

		private void NetworkPacketReceived(object s, byte[] packet)
		{
			if (PluginSettings["PrintInboundPackets"].AsBool())
			{
				Chat.WriteLine("----------------------Inbound Packet-----------------", ChatColor.Green);
				Chat.WriteLine($"{ BitConverter.ToString(packet).Replace("-", " ")}");
				Chat.WriteLine("-----------------------------------------------------------", ChatColor.Green);
			}
		}

		private void NetworkPacketSent(object s, byte[] packet)
		{
			if (PluginSettings["PrintOutboundPackets"].AsBool())
			{
				Chat.WriteLine("----------------------Outbound Packet---------------", ChatColor.Red);
				Chat.WriteLine($"{ BitConverter.ToString(packet).Replace("-", " ")}");
				Chat.WriteLine("-----------------------------------------------------------", ChatColor.Red);
			}
		}

	}
}