using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Hotfix_Applicator
{
    class Validator
    {
        public Boolean ValidateIP(String address)
        {
            try
            {
                if(address.Trim().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length == 4) {
                    IPAddress ipAddr;
                    if (IPAddress.TryParse(address, out ipAddr))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean ValidateEndingOctet(string[] startIpOctets, string endIpLastOctet)
        {
            string ip = startIpOctets[0] + "." + startIpOctets[1] + "." + startIpOctets[2] + "." + endIpLastOctet;
            if (!ValidateIP(ip))
            {
                return false;
            }
            try
            {
                int endOfFirst = Int32.Parse(startIpOctets[3]);
                int endOfEnd = Int32.Parse(endIpLastOctet);

                return (endOfEnd < endOfFirst) ? false : true; 
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
