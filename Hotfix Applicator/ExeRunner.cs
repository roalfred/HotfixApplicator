using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Hotfix_Applicator
{
    class ExeRunner
    {
        public string runCommand(String exeName, String arguments)
        {
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.RedirectStandardOutput = true;
            info.FileName = exeName;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.Arguments = "/C " + arguments;
            process.StartInfo = info;
            process.Start();
            string response = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return response;
        }
    }
}
