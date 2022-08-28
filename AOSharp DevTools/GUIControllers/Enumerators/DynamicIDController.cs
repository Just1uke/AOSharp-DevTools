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
using System.Runtime.InteropServices;

using DevTools.Unmanaged.GUI;

namespace DevTools.GUIControllers.Enumerators.DynamicID
{



    public class DynamicIDController : Controller
    {

        private int curSliderValue = 0;
        public readonly int MIN_VALUE;
        public readonly int MAX_VALUE;
        

        public DynamicIDController(String PluginDirectory, AOSharp.Core.Settings PluginSettings, DynamicIdDisplayType Type, string DisplayName, string KeyPrefix, int MinimumValue=-1, int MaximumValue=-1) : base(PluginDirectory, PluginSettings)
        {
            DisplayType = Type;
            Name = DisplayName;
            Prefix = KeyPrefix;
            MIN_VALUE = MinimumValue;
            MAX_VALUE = MaximumValue;
        }

        public override bool InitializeWindow(bool AutoOpen)
        {
            
            string xmlFile;

            switch (DisplayType)
            {
                case DynamicIdDisplayType.Text:
                    xmlFile = "TypeText.xml";
                    break;
                case DynamicIdDisplayType.Bitmap:
                    xmlFile = "TypeBitmap.xml";
                    break;
                default:
                    Chat.WriteLine("WARNING: Attempted to access an unset DynamicID display type.", ChatColor.Red);
                    throw new NotImplementedException("You must define a DynamicIdDisplayType");
            }
            return base.InitializeWindow(PluginDirectory + $"\\UI\\Enumerators\\DynamicID\\{xmlFile}", new Rect(0, 0, 455, 345),
                windowName: $"Developer Tools - {Name} Enumerator",
                windowStyle: WindowStyle.Default,
                windowFlags: WindowFlags.AutoScale | WindowFlags.NoFade,
                autoOpen: AutoOpen);
        }


        unsafe public override void CheckForClickedButtons()
        {
            Window newWindow = Window.GetWindowByName($"Developer Tools - {Name} Enumerator");
            if (newWindow != null && newWindow.IsValid)
            {
                if (newWindow.FindView("Enumerator", out View outView))
                {
                    if (outView.FindChild("slideSelect", out AOSharp.Core.UI.SliderView sliderSelect))
                    {
                        
                        if ((int)sliderSelect.GetValue() != curSliderValue)
                        {
                            ChangeValue(outView, (int)sliderSelect.GetValue());
                        }
                    }
                    if (outView.FindChild("btnDecreaseId", out AOSharp.Core.UI.Button btnDecreaseId))
                    {
                        btnDecreaseId.Tag = outView;
                        btnDecreaseId.Clicked = (object s, ButtonBase button) => {
                            ChangeValue(outView, curSliderValue - 1);
                            Chat.WriteLine("Decrease");
                        };
                    }
                    if (outView.FindChild("btnIncreaseId", out AOSharp.Core.UI.Button btnIncreaseId))
                    {
                        btnIncreaseId.Tag = outView;
                        btnIncreaseId.Clicked = (object s, ButtonBase button) => {
                            ChangeValue(outView, curSliderValue + 1);
                        };
                    }
                    if (outView.FindChild("btnSetId", out AOSharp.Core.UI.Button btnSetId))
                    {
                        btnSetId.Tag = outView;
                        btnSetId.Clicked = (object s, ButtonBase button) => {
                            if (outView.FindChild("tivId", out AOSharp.Core.UI.TextInputView idInput))
                            {
                                Chat.WriteLine(idInput.Text, ChatColor.Red);
                                if (idInput != null && idInput.Text != String.Empty && int.TryParse(idInput.Text, out int newValue))
                                {
                                    idInput.Text = $"{ChangeValue(outView, Int16.Parse(idInput.Text))}";
                                } else
                                {
                                    Chat.WriteLine($"Unable to parse number: {idInput.Text}", ChatColor.Red);
                                }

                            }
                        };
                    }
                }
                else
                {
                    Chat.WriteLine("Unable to find Enumerator View.", ChatColor.Red);
                }
            }
        }

        unsafe private int ChangeValue(View view, int value)
        {
            if(MIN_VALUE < 0 || MAX_VALUE < 0)
            {
                Chat.WriteLine($"Min: {MIN_VALUE}, Max: {MAX_VALUE}");
                Chat.WriteLine($"WARNING: MIN_VALUE or MAX_VALUE not set on DynamicID Type {Name}");
            }

            if (value <= MAX_VALUE && value >= MIN_VALUE)
            {
                try
                {
                    try
                    {

                        char* dynamicIdChar = DynamicID_t.GetID(DynamicID_t.GetInstance(), Prefix, value);
                        string dynamicIdString = AOSharp.Common.Helpers.Utils.UnsafePointerToString((IntPtr)dynamicIdChar);
                        if (dynamicIdString != null && dynamicIdString != String.Empty)
                        {
                            if (view.FindChild("tvIdName", out AOSharp.Core.UI.TextView dynamicIdStringTV))
                            {
                                dynamicIdStringTV.Text = dynamicIdString;
                            }
                        }
                    }
                    catch (Exception f)
                    {
                        Chat.WriteLine($"Exception: {f}", ChatColor.Red);
                    }
                    if (DisplayType == DynamicIdDisplayType.Bitmap)
                    {
                        if (view.FindChild("bmvPreview", out AOSharp.Core.UI.BitmapView bmv))
                        {
                            bmv.SetBitmap(value);
                        }
                        else
                        {
                            Chat.WriteLine("Unable to find bmvPreview!", ChatColor.Red);
                        }
                    }
                    if (view.FindChild("tivId", out AOSharp.Core.UI.TextInputView sliderValueLabel))
                    {
                        sliderValueLabel.Text = $"{value}";
                    }
                    if (view.FindChild("slideSelect", out AOSharp.Core.UI.SliderView slider))
                    {
                        slider.SetValue(value);
                        try
                        {
                            /*
                           GCHandle objHandle = GCHandle.Alloc(slider, GCHandleType.WeakTrackResurrection);
                           IntPtr address = GCHandle.ToIntPtr(objHandle);
                           IntPtr offsetAddress = IntPtr.Add(address, 0x1c);


                           Chat.WriteLine($"Staight address: {address.ToString("X")}");
                           Chat.WriteLine($"Offset address: {offsetAddress.ToString("X")}");
                           Chat.WriteLine($"16 Straight look first: {Marshal.ReadInt16(offsetAddress).ToString("X")}");
                           Chat.WriteLine($"32 Straight look first: {Marshal.ReadInt32(offsetAddress).ToString("X")}");
                           Chat.WriteLine($"Byte Straight look first: {Marshal.ReadByte(offsetAddress).ToString("X")}");



                           bool found = false;

                           for (int i = 0; i < 10000; i++)
                           {
                               TypedReference tr = __makeref(slider);
                               IntPtr ptr = (IntPtr.Add(**(IntPtr**)(&tr), i));

                               int straightValue;
                               int stv16 = Marshal.ReadInt16(ptr);
                               int stv32 = Marshal.ReadInt32(ptr);
                               int stvbyte = Marshal.ReadByte(ptr);


                               //int ptrValue = Marshal.ReadInt32(Marshal.ReadIntPtr(ptr));
                               if ((stv16 > 790 && stv16 < 800))
                               {
                                   Chat.WriteLine($"16 - Offset {i} = {stv16}");
                                   //Chat.WriteLine($"Offset {i} = {ptrValue}");

                                   found = true;
                               }
                               if ((stv32 > 790 && stv32 < 800))
                               {
                                   Chat.WriteLine($"32 - Offset {i} = {stv32}");
                                   //Chat.WriteLine($"Offset {i} = {ptrValue}");

                                   found = true;
                               }
                               if ((stvbyte > 790 && stvbyte < 800))
                               {
                                   Chat.WriteLine($"Byte - Offset {i} = {stvbyte}");
                                   //Chat.WriteLine($"Offset {i} = {ptrValue}");

                                   found = true;
                               }
                           }


                           if (found)
                           {
                               Chat.WriteLine("Found!", ChatColor.Green);
                           } else
                           {
                               Chat.WriteLine("Not found.", ChatColor.Red);
                           }
                           */
                        }
                        catch (Exception e)
                        {
                            Chat.WriteLine($"Exception. Are you surprised? {e}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Chat.WriteLine($"Unable to change value to {value}: {e}", ChatColor.Red);
                }

                curSliderValue = value;
            }
            return curSliderValue;
        }

        public enum DynamicIdDisplayType
        {
            Unset = 0x0,
            Text = 0x1,
            Bitmap = 0x2,

        }

        protected string _prefix;
        public string Prefix
        {
            get
            {
                if (string.IsNullOrEmpty(_prefix))
                {
                    Chat.WriteLine("WARNING: Attempted to access a DynamicID with an unset prefix.", ChatColor.Red);
                    throw new NotImplementedException("You must define a DynamicID prefix");
                }
                else
                {
                    return _prefix;
                }
            }
            set
            {
                _prefix = value;
            }
        }

        protected string _name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    Chat.WriteLine("WARNING: Attempted to access a DynamicID with an unset name.", ChatColor.Red);
                    throw new NotImplementedException("You must define a DynamicID Type");
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }

        protected DynamicIdDisplayType _display_type = DynamicIdDisplayType.Unset;
        public DynamicIdDisplayType DisplayType
        {
            get
            {
                if (_display_type == DynamicIdDisplayType.Unset)
                {
                    Chat.WriteLine("WARNING: Attempted to access an unset DynamicID display type.", ChatColor.Red);
                    throw new NotImplementedException("No display type defined.");
                }
                else
                {
                    return _display_type;
                }
            }
            set
            {
                _display_type = value;
            }
        }

    }
}
