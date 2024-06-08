using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velopack.Backend.Installer
{
    public static class Velopack
    {
        public static void Run()
        {
            VelopackApp.Build().Run();
        }
        public static async Task UpdateMyApp()
        {
            var mgr = new UpdateManager("C:\\Velopack");

            // check for new version
            var newVersion = await mgr.CheckForUpdatesAsync();
            if (newVersion == null)
                return; // no update available

            // download new version
            await mgr.DownloadUpdatesAsync(newVersion);

            // install new version and restart app
            mgr.ApplyUpdatesAndRestart(newVersion);
        }
    }
}
