using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTalk
{
    class InformationContainer
    {
        public static string nickname = "";
        public static string selfIP = "";
        public static List<string> IPAddresses = new List<string>();
        public static void PushIPAddressesIntoLoop(string IPAddress) {
            if (!FindIPAddress(IPAddress)) {
                IPAddresses.Add(IPAddress);
            }
        }
        private static bool FindIPAddress(string IPAddress) {
            bool result = false;
            foreach (string IP in IPAddresses) {
                if (IP==IPAddress) {
                    result = true;
                }
            }

            return result;
        }
    }


}
