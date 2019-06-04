using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotfix_Applicator
{
    public partial class Main : Form
    {
        string workingDirectory = Path.GetTempPath() + "hotfix";
        string kb, pathToHotfix;
        bool startIpValidated, endIpValidated;
        List<string> ipAddresses = new List<string>();
        Validator validator = new Validator();
        TextReader reader;
        ExeRunner runner = new ExeRunner();

        public Main()
        {
            InitializeComponent();
        }

        private void Single_opt_CheckedChanged(object sender, EventArgs e)
        {
            start_ip_lbl.Visible = true;
            start_ip_txt.Visible = true;
            start_ip_lbl.Text = "IP";
            
            end_ip_lbl.Visible = false;
            end_ip_prefix_txt.Visible = false;
            end_ip_suffix_txt.Visible = false;

            get_list_btn.Visible = false;
            ip_list_name_display_box.Visible = false;
        }

        private void Range_opt_CheckedChanged(object sender, EventArgs e)
        {
            start_ip_lbl.Visible = true;
            start_ip_txt.Visible = true;
            start_ip_lbl.Text = "From";

            if (startIpValidated)
            {
                end_ip_lbl.Visible = true;
                end_ip_prefix_txt.Visible = true;
                end_ip_suffix_txt.Visible = true;
            }

            get_list_btn.Visible = false;
            ip_list_name_display_box.Visible = false;
        }

        private void List_opt_CheckedChanged(object sender, EventArgs e)
        {
            start_ip_lbl.Visible = false;
            start_ip_txt.Visible = false;

            end_ip_lbl.Visible = false;
            end_ip_prefix_txt.Visible = false;
            end_ip_suffix_txt.Visible = false;

            get_list_btn.Visible = true;
            ip_list_name_display_box.Visible = true;

        }

        private void Get_list_btn_Click(object sender, EventArgs e)
        {
            open_ip_list_dialog.ShowDialog();
        }

        private void Get_hotfix_btn_Click(object sender, EventArgs e)
        {
            open_hotfix_dialog.ShowDialog();
        }

        private void Open_ip_list_dialog_FileOk(object sender, CancelEventArgs e)
        {
            String fileName, line, pathToIpList;

            fileName = open_ip_list_dialog.SafeFileName;
            pathToIpList = open_ip_list_dialog.FileName;
            reader = new StreamReader(pathToIpList);

            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (!validator.ValidateIP(line))
                {
                    feedback_box.Clear();
                    ipAddresses.Clear();
                    feedback_box.AppendText(line + " is not a valid IP.  Please fix the list and retry the import." +Environment.NewLine);
                    break;
                }
                ipAddresses.Add(line);
            }
            reader.Close();
            ip_list_name_display_box.Text = fileName;
        }

        private void Open_hotfix_dialog_FileOk(object sender, CancelEventArgs e)
        {
            hotfix_name_display_box.Text = open_hotfix_dialog.SafeFileName;
            pathToHotfix = open_hotfix_dialog.FileName;
            runner.runCommand("cmd.exe", "mkdir "+workingDirectory);
            feedback_box.AppendText (runner.runCommand("cmd.exe", "expand -f:\"PkgInstallOrder.txt\" \"" + @pathToHotfix + "\" " + workingDirectory));

            try
            {
                reader = new StreamReader(workingDirectory + @"\PkgInstallOrder.txt");
                while (true)
                {
                    string line = reader.ReadLine();
                    if(line == null)
                    {
                        kb_number_txt.Clear();
                        reader.Close();
                        break;
                    }
                    else if (line.Contains("KB"))
                    {
                        kb = line.Substring(line.IndexOf("-") + 1, line.LastIndexOf("-") - line.IndexOf("-") - 1);
                        kb_number_txt.Text = kb;
                        reader.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                feedback_box.Clear();
                feedback_box.AppendText(ex.Message + Environment.NewLine);
                kb_number_txt.Clear();
            }
            runner.runCommand("cmd.exe", "rmdir /Q /S " + workingDirectory);
        }

        private void Report_only_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (report_only_chkbox.Checked || skip_if_present_chkbox.Checked)
            {
                kb_number_lbl.Visible = true;
                kb_number_txt.Visible = true;
            }
            else
            {
                kb_number_lbl.Visible = false;
                kb_number_txt.Visible = false;
            }

            skip_if_present_chkbox.Visible = !report_only_chkbox.Checked;
            force_restart_chkbox.Visible = skip_if_present_chkbox.Visible;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            feedback_box.Clear();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            feedback_box.Clear();

            if(ipAddresses.Count() > 0)
            {
                if (pathToHotfix != null)
                {

                }
                else
                {
                    feedback_box.AppendText("No hotfix selected." + Environment.NewLine);
                }
            }
            else
            {
                feedback_box.AppendText("No valid IP to work with.  Verify your IP input."+Environment.NewLine);
            }
        }

        private void Start_ip_txt_Leave(object sender, EventArgs e)
        {
            feedback_box.Clear();
            startIpValidated = validator.ValidateIP(start_ip_txt.Text);
            if (!startIpValidated)
            {
                feedback_box.AppendText("IP address is not valid" + Environment.NewLine);
                start_ip_txt.BackColor = Color.LightPink;
                end_ip_prefix_txt.Clear();
                end_ip_suffix_txt.Clear();
            }
            else
            {
                start_ip_txt.BackColor = Color.White;
                string[] octets = start_ip_txt.Text.Split('.');
                end_ip_prefix_txt.Text = octets[0] + "." + octets[1] + "." + octets[2] + ".";

                if (range_opt.Checked)
                {
                    end_ip_lbl.Visible = true;
                    end_ip_prefix_txt.Visible = true;
                    end_ip_suffix_txt.Visible = true;
                }
            }
        }

        private void End_ip_suffix_txt_Leave(object sender, EventArgs e)
        {
            feedback_box.Clear();
            ipAddresses.Clear();
            string[] startIpOctets = start_ip_txt.Text.Split('.');
            string endIpOctet = end_ip_suffix_txt.Text;
            endIpValidated = validator.ValidateEndingOctet(startIpOctets, endIpOctet);

            if (!endIpValidated)
            {
                feedback_box.AppendText("Not a valid ending IP in the range.  Check the ending IP and make sure that its not lower than the starting IP" + Environment.NewLine);
                end_ip_suffix_txt.BackColor = Color.LightPink;
            }
            else if (startIpValidated && endIpValidated)
            {
                end_ip_suffix_txt.BackColor = Color.White;
                int endOfFirst = Int32.Parse(startIpOctets[3]);
                int endOfEnd = Int32.Parse(endIpOctet);

                for (int i = endOfFirst; i <= endOfEnd; i++)
                {
                    ipAddresses.Add(startIpOctets[0]+"."+ startIpOctets[1]+"."+ startIpOctets[2]+"."+i.ToString());
                }
            }

        }

        private void Skip_if_present_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (skip_if_present_chkbox.Checked || report_only_chkbox.Checked)
            {
                kb_number_lbl.Visible = true;
                kb_number_txt.Visible = true;
            }
            else
            {
                kb_number_lbl.Visible = false;
                kb_number_txt.Visible = false;
            }
        }
    }
}
