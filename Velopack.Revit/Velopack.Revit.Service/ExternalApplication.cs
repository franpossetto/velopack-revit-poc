using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using Autodesk.Windows;
using System;
using Velopack.Backend.Installer;

namespace Velopack.Revit.Service
{
    [Transaction(TransactionMode.Manual)]
    public class ExternalApplication : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string RIBBON_TAB = "Velopack";
            Velopack.Backend.Installer.Velopack.Run();
            application.CreateRibbonTab(RIBBON_TAB);


            Autodesk.Revit.UI.RibbonPanel versionPanel = application.CreateRibbonPanel(RIBBON_TAB, "Version");

            PushButtonData pushButtonData = new PushButtonData(
                "About",
                "About",
                typeof(ExternalCommand).Assembly.Location,
                typeof(ExternalCommand).FullName);

            PushButton pushButton = versionPanel.AddItem(pushButtonData) as PushButton;


            return Result.Succeeded;
        }
    }
}
