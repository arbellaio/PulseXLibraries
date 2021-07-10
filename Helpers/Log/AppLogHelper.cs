using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;

namespace PulseXLibraries.Helpers.Log
{
    public class AppLogHelper
    {
        public static void Log(string logKey, string logValue)
        {
                Analytics.TrackEvent(logKey, new Dictionary<string, string> {
                    { "Date", DateTime.Now.Date.ToString("MM/dd/yyyy HH:mm tt")},
                    {logKey, logValue}
                });
        }
    }
}