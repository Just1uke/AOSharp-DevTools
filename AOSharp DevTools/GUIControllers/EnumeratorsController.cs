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
	public class EnumeratorsController : Controller
	{
		public EnumeratorsController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
		{

		}

        public override bool InitializeWindow(bool AutoOpen)
		{
			return base.InitializeWindow(PluginDirectory + "\\UI\\Enumerators.xml", new Rect(0, 0, 455, 345),
				windowName: "Developer Tools - Enumerators",
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

							if (UIView.FindChild("Open_Command", out AOSharp.Core.UI.Button btnOpenCommand))
							{
								btnOpenCommand.Tag = UIView;
								btnOpenCommand.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("CommandController"); }; // Open a new "Command" window.
							}
							if (UIView.FindChild("Open_Destination", out AOSharp.Core.UI.Button btnOpenDestination))
							{
								btnOpenDestination.Tag = UIView;
								btnOpenDestination.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("DestinationController"); }; // Open a new "Destination" window.
							}
							if (UIView.FindChild("Open_GFX", out AOSharp.Core.UI.Button btnOpenGFX))
							{
								btnOpenGFX.Tag = UIView;
								btnOpenGFX.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("GFXController"); }; // Open a new "GFX" window.
							}
							if (UIView.FindChild("Open_Hotspot", out AOSharp.Core.UI.Button btnOpenHotspot))
							{
								btnOpenHotspot.Tag = UIView;
								btnOpenHotspot.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("HotspotController"); }; // Open a new "Hotspot" window.
							}
							if (UIView.FindChild("Open_Key", out AOSharp.Core.UI.Button btnOpenKey))
							{
								btnOpenKey.Tag = UIView;
								btnOpenKey.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("KeyController"); }; // Open a new "Key" window.
							}
							if (UIView.FindChild("Open_Packet", out AOSharp.Core.UI.Button btnOpenPacket))
							{
								btnOpenPacket.Tag = UIView;
								btnOpenPacket.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("PacketController"); }; // Open a new "Packet" window.
							}
							if (UIView.FindChild("Open_Program", out AOSharp.Core.UI.Button btnOpenProgram))
							{
								btnOpenProgram.Tag = UIView;
								btnOpenProgram.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("ProgramController"); }; // Open a new "Program" window.
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
