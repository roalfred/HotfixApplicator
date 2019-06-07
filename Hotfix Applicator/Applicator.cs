using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Hotfix_Applicator
{
    class Applicator
    {
        ExeRunner runner = new ExeRunner();

        public string[] ChecForKB(string address, string kb)
        {
            string[] list = new string[3];
            list[0] = address;

            Ping pinger = new Ping();
            PingReply response = pinger.Send(address);
            list[1] = response.Status.ToString();

            if (list[1] == "Success")
            {
                string found = runner.runCommand("cmd.exe", "wmic /node:" + address + " qfe get hotfixid | find \"" + kb + "\"");
                if (found == kb)
                {
                    list[2] = "Installed";
                }
                else
                {
                    list[2] = "Not Installed";
                }
            }
            else
            {
                list[2] = "Address Unreachable";
            }
            return list;
        }

        public string InstallHotfix(string address, string hotfix, string restartOption) {

            string response = runner.runCommand("PsExec.exe", @"-accepteula -nobanner -s \\" + address + @" cmd /c C:\" + hotfix + " /quiet /" + restartOption);
            Console.WriteLine(response);

            return response;
        }
    }
}
