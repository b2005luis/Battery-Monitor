using System;
using System.Diagnostics;
using System.Management;
using BatteryMonitor.App.Domain;

namespace BatteryMonitor.App.Service
{
    public class BatteryInfoService
    {
        private Win32_Battery win32Battery;

        public int Info()
        {
            try
            {
                var scope = new ManagementScope();
                var query = new SelectQuery("Select EstimatedChargeRemaining From Win32_Battery");
                using (var searcher = new ManagementObjectSearcher(scope, query))
                {
                    using (var objectCollection = searcher.Get())
                    {
                        foreach (ManagementObject managementObject in objectCollection)
                        {
                            var pData = managementObject.Properties["EstimatedChargeRemaining"];
                            var value = short.Parse(pData.Value.ToString().Replace("%", ""));
                            return value;
                        }
                    }
                }

                return -1;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return -1;
            }
        }

        public Win32_Battery Informations()
        {
            win32Battery = new Win32_Battery();
            
            try
            {
                var scope = new ManagementScope();
                var query = new SelectQuery("Select * From Win32_Battery");
                using (var searcher = new ManagementObjectSearcher(scope, query))
                {
                    using (var objectCollection = searcher.Get())
                    {
                        foreach (ManagementObject managementObject in objectCollection)
                        {
                            win32Battery.Name = (string) managementObject.Properties["Name"].Value;
                            win32Battery.EstimatedChargeRemaining = (ushort) managementObject.Properties["EstimatedChargeRemaining"].Value;
                            win32Battery.BatteryStatus = (ushort) managementObject.Properties["BatteryStatus"].Value;
                            win32Battery.Status = (string) managementObject.Properties["Status"].Value;
                        }
                    }
                }

                return win32Battery;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return win32Battery;
            }
        }
    }
}