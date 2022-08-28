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
	public class ModulesController : Controller
	{
		public ModulesController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings)
		{

		}

		public override bool InitializeWindow(bool AutoOpen)
		{
			return base.InitializeWindow(PluginDirectory + "\\UI\\Modules.xml", new Rect(0, 0, 455, 345),
				windowName: "Developer Tools - Modules",
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
							if (UIView.FindChild("Open_VisualFX_t", out AOSharp.Core.UI.Button btnOpenVisualFX_TT))
							{
								btnOpenVisualFX_TT.Tag = UIView;
								btnOpenVisualFX_TT.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("VisualEnvFX_tController"); }; // Open a new "VisualEnvFX_t" window.
							}
							if (UIView.FindChild("Open_FlowControlModule_t", out AOSharp.Core.UI.Button btnOpenFlowControleModule_t))
							{
								btnOpenFlowControleModule_t.Tag = UIView;
								btnOpenFlowControleModule_t.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("FlowControlModule_tController"); }; // Open a new "FlowControlModule_t" window.
							}
							if (UIView.FindChild("Open_SceneBase_t", out AOSharp.Core.UI.Button btn_OpenSceneBase_t))
							{
								btn_OpenSceneBase_t.Tag = UIView;
								btn_OpenSceneBase_t.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("SceneBase_tController"); }; // Open a new "SceneBase_t" window.
							}
							if (UIView.FindChild("Open_DisplaySystem_t", out AOSharp.Core.UI.Button btnOpenDisplaySystem_t))
							{
								btnOpenDisplaySystem_t.Tag = UIView;
								btnOpenDisplaySystem_t.Clicked = (object s, ButtonBase button) => { ControllerManager.Open("DisplaySystem_tController"); }; // Open a new "SceneBase_t" window.
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
