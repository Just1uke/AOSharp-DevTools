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

using DevTools.Unmanaged.GUI;

namespace DevTools.GUIControllers
{
	public class SceneBase_tController : Controller
	{
		public SceneBase_tController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
		{

		}

		public override bool InitializeWindow(bool AutoOpen)
		{
			return base.InitializeWindow(PluginDirectory + "\\UI\\Modules\\SceneBase_t.xml", new Rect(0, 0, 455, 345),
				windowName: "Developer Tools - SceneBase_t",
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
							if (UIView.FindChild("SceneBase_t::EnableDebugTextArea()", out AOSharp.Core.UI.Button debugCrashAnarchyMessage1))
							{
								debugCrashAnarchyMessage1.Tag = UIView;
								debugCrashAnarchyMessage1.Clicked = (object s, ButtonBase button) => {
									Chat.WriteLine($"SceneBase_t::EnableDebugTextArea() = {DevTools.Unmanaged.GUI.SceneBase_t.EnableDebugTextArea((IntPtr)SceneBase_t.CurrentScene)}");
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
