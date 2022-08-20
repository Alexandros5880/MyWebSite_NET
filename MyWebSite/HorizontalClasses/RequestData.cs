using System;
using System.Runtime.InteropServices;

namespace MyWebSite.HorizontalClasses
{
    public class RequestData
    {

        public string IpAddress(System.Net.IPAddress clientIpAddress)
        {
            string ipAddress = clientIpAddress.ToString();
            int idx = ipAddress.LastIndexOf(':');
            ipAddress = ipAddress[(idx + 1)..];
            System.Diagnostics.Debug.WriteLine($"Ip: {ipAddress}");
            return ipAddress;
        }

    }
}
