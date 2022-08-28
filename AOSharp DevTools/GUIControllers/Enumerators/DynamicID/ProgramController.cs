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
    public class ProgramController : DynamicIDController
    {

        public ProgramController(String PluginDirectory, AOSharp.Core.Settings PluginSettings) : base(PluginDirectory, PluginSettings, DynamicIdDisplayType.Text, "Program", "PROGRAM_", 0, 796)
        {
            //Chat.WriteLine(MIN_VALUE);
            //Chat.WriteLine(MAX_VALUE);
        }
        /*
        public override bool InitializeWindow(bool AutoOpen)
        {
            return base.InitializeWindow(PluginDirectory + "\\UI\\Enumerators\\DynamicID\\GFX.xml", new Rect(0, 0, 455, 345),
                windowName: "Developer Tools - GFX Enumerator",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
                autoOpen: AutoOpen);
        }


        unsafe public override void CheckForClickedButtons()
        {
            Window newWindow = Window.GetWindowByName("Developer Tools - GFX Enumerator");
            if (newWindow != null && newWindow.IsValid)
            {
                View outView;
                newWindow.FindView("GFX Enumerator", out outView);
                if (outView != null)
                {
                    if (outView.FindChild("GFXSelectSlider", out AOSharp.Core.UI.SliderView gfxSelectSlider))
                    {
                        if ((int)gfxSelectSlider.GetValue() != curSliderValue)
                        {
                            ChangeBitmapValue(outView, (int)gfxSelectSlider.GetValue());
                        }
                        if (outView.FindChild("brnDecreaseGFXId", out AOSharp.Core.UI.Button btnDecreaseGFXId))
                        {
                            btnDecreaseGFXId.Tag = outView;
                            btnDecreaseGFXId.Clicked = (object s, ButtonBase button) => {
                                ChangeBitmapValue(outView, curSliderValue - 1);
                                Chat.WriteLine("Decrease");
                            };
                        }
                        if (outView.FindChild("btnIncreaseGFXId", out AOSharp.Core.UI.Button btnIncreaseGFXId))
                        {
                            btnIncreaseGFXId.Tag = outView;
                            btnIncreaseGFXId.Clicked = (object s, ButtonBase button) => {
                                ChangeBitmapValue(outView, curSliderValue + 1);
                                Chat.WriteLine("Increase");
                            };
                        }
                        if (outView.FindChild("btnSetGFXId", out AOSharp.Core.UI.Button btnSetId))
                        {
                            btnSetId.Tag = outView;
                            btnSetId.Clicked = (object s, ButtonBase button) => {
                                if (outView.FindChild("tivGFXId", out AOSharp.Core.UI.TextInputView idInput))
                                {
                                    if (idInput != null && idInput.Text != String.Empty && int.TryParse(idInput.Text, out int newValue))
                                    {
                                        idInput.Text = $"{ChangeBitmapValue(outView, Int16.Parse(idInput.Text))}";
                                    }

                                }
                            };
                        }
                        gfxSelectSlider.SetValue(curSliderValue);
                    }
                }
                else
                {
                    Chat.WriteLine("Unable to find GFX Enumerator View.", ChatColor.Red);
                }
            }
        }

        unsafe private int ChangeBitmapValue(View view, int value)
        {
            // Not entirely sure what the bounds are here, but we get an access violation on anything >797
            if (value <= GFX_MAX_VALUE && value >= GFX_MIN_VALUE)
            {
                try
                {
                    try
                    {
                        char* dynamicIdChar = DynamicID_t.GetID(DynamicID_t.GetInstance(), "GFX_", value);
                        string dynamicIdString = AOSharp.Common.Helpers.Utils.UnsafePointerToString((IntPtr)dynamicIdChar);
                        if (dynamicIdString != null && dynamicIdString != String.Empty)
                        {
                            if (view.FindChild("tvGFXIdName", out AOSharp.Core.UI.TextView dynamicIdStringTV))
                            {
                                dynamicIdStringTV.Text = dynamicIdString;
                            }
                        }
                    }
                    catch (Exception f)
                    {
                        Chat.WriteLine($"Exception: {f}");
                    }
                    if (view.FindChild("bmvGFXPreview", out AOSharp.Core.UI.BitmapView bmv))
                    {
                        bmv.SetBitmap(value);
                    }
                    if (view.FindChild("tivGFXId", out AOSharp.Core.UI.TextInputView sliderValueLabel))
                    {
                        sliderValueLabel.Text = $"{value}";
                    }
                    if (view.FindChild("GFXSelectSlider", out AOSharp.Core.UI.SliderView slider))
                    {
                        slider.SetValue(value);
                    }
                }
                catch (Exception e)
                {
                    Chat.WriteLine($"Unable to change Bitmap preview value to {value}: {e}");
                }

                curSliderValue = value;
            }
            return curSliderValue;
        }
        */
    }

}
