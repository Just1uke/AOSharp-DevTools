using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using AOSharp.Core.UI;

namespace DevTools
{

    static class ControllerManager 
    {
        public static ControllerList controllers = new ControllerList();

        public static bool Open(String controllerName)
        {
            return OpenController(controllerName);
        }

        public static bool OpenController(String controllerName)
        {
            try
            {
                if (!ControllerExists(controllerName))
                    return false;

                return controllers[controllerName].Open();
            } catch (Exception e)
            {
                Chat.WriteLine($"Unable to open controller {controllerName}. Are you sure it's registered with the Controller manager?", AOSharp.Common.GameData.ChatColor.Red);
                Chat.WriteLine($"Exception: {e}", AOSharp.Common.GameData.ChatColor.Red);
                return false;
            }
        }

        public static bool ControllerExists(String controllerName)
        {
            return controllerName.Contains(controllerName);
        }
    }



    class ControllerList : KeyedCollection<String, Controller>
    {
        protected override String GetKeyForItem(Controller controller)
        {
            return controller.name;
        }

        protected override void InsertItem(int index, Controller newController)
        {
            base.InsertItem(index, newController);
            newController.Registered?.Invoke(null, null);
            newController.RegisterGlobalVariables();
            newController.RegisterCommands();
            newController.RegisterControllerCallbacks();
        }


        protected override void RemoveItem(int index)
        {

        }

        protected override void SetItem(int index, Controller newItem)
        { 
        }

        protected override void ClearItems()
        {
        }
    }


}
