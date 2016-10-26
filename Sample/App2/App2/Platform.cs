using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;

namespace App2
{
    public enum DeviceFamily
    {
        Unknown,
        Xbox,
        Desktop,
        Mobile,
        IoT,
    }

    public class Platform
    {
        /// <summary>
        /// Provides access to application services.
        /// </summary>
        public static Platform Current { get; private set; }


        /// <summary>
        /// Gets the current device family this app is executing on.
        /// </summary>
        public static DeviceFamily DeviceFamily { get; private set; }


        static Platform()
        {
            //DEMO 2.0 Family Detection
            Debug.WriteLine("DeviceFamily: " + AnalyticsInfo.VersionInfo.DeviceFamily);

            // Determine what device this is running on and store the appropriate enumeration representing that device
            switch (AnalyticsInfo.VersionInfo.DeviceFamily)
            {
                case "Windows.Desktop":
                    DeviceFamily = DeviceFamily.Desktop;
                    break;
                case "Windows.Mobile":
                    DeviceFamily = DeviceFamily.Mobile;
                    break;
                case "Windows.Xbox":
                    DeviceFamily = DeviceFamily.Xbox;
                    break;
                case "Windows.IoT":
                    DeviceFamily = DeviceFamily.IoT;
                    break;
                default:
                    DeviceFamily = DeviceFamily.Unknown;
                    break;
            }
        }
    }
}
