using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hotfix_Applicator
{
    public partial class Main : Form
    {
        string workingDirectory = Path.GetTempPath() + "hotfix";
        string kb, pathToHotfix, hotfix;
        bool startIpValidated, endIpValidated;
        List<string> ipAddresses = new List<string>();
        List<string[]> report = new List<string[]>();
        Validator validator = new Validator();
        TextReader reader;
        ExeRunner runner = new ExeRunner();
        Applicator applicator = new Applicator();

        public Main()
        {
            InitializeComponent();
        }

        /*
         * Sets the single IP label to "IP" and makes it visible.  Sets it text field is set to visible,
         * Sets the visibility all other fields and labels in the IP section to false
         */
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

        /*
         * Sets the start IP labels and text boxe to visible and if 
         * the start IP field has been validated, the end IP label and text input will be made visible
         * Sets the visibility of the "Get List" option to false
         */
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

        /*
         * Sets the single and range input fields and labels to a  visibility of false 
         * Sets the "Get List" button and dispay field to visible
         */
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

        /*
         * Opens the windows Open File Dialog to search for .txt files
         */
        private void Get_list_btn_Click(object sender, EventArgs e)
        {
            open_ip_list_dialog.ShowDialog();
        }


        /*
         * Opens the windows Open File Dialog to search for .msu files 
         */
        private void Get_hotfix_btn_Click(object sender, EventArgs e)
        {
            open_hotfix_dialog.ShowDialog();
        }


        /*
         * Reads through the selected ip list file, line by line, and validates each line as an IP Address.
         * Adds each validated IP to an ipAddress list
         * Clears the list if an IP is not valid and prints a message to the feedback pane, then exits the loop
        */
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


        /*
         * Extracts the XML file from the hotfix to the folder %temp%\hotfix\ folder searches for the KB number within the extracted file
         * Reads the KB number and populates the KB number if found, along with the file name field
         * Removes the temporary directory and extracted file upon completion
         * The KB number is used to determine if it is already instaled
         */
        private void Open_hotfix_dialog_FileOk(object sender, CancelEventArgs e)
        {
            hotfix = open_hotfix_dialog.SafeFileName;
            hotfix_name_display_box.Text = hotfix;
            pathToHotfix = open_hotfix_dialog.FileName;
            runner.runCommand("cmd.exe", "rmdir /Q /S " + workingDirectory);
            runner.runCommand("cmd.exe", "mkdir "+workingDirectory);
            runner.runCommand("cmd.exe", "expand -f:\"*.xml\" \"" + @pathToHotfix + "\" " + workingDirectory+" > nul 2>&1");
            try
            {
                string[] files = Directory.GetFiles(workingDirectory);
                reader = new StreamReader(files[0]);
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
                        kb = line.Substring(line.IndexOf("KB"), line.LastIndexOf("version") - line.IndexOf("KB") - 2);
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
                reader.Close();
            }
            runner.runCommand("cmd.exe", "rmdir /Q /S " + workingDirectory);
        }


        /*
         * Manipulates the visibility of the KB number label and text,
         * Manipulates the visibility of the Skip If Present and Report Only check boxes
         */
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


        /*
         * Clears the feedback area upon click
         */
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            feedback_box.Clear();
        }



        /*
         * Validates the input in the single IP field when focus is lost
         * Changes the background to light pink if the input did not validate and displays a message in the feedback area
         * Changes the background to white if it is validated and pre-populates the ending IP prefix
         */
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



        /*
         * Validates the ending IP in the range, if IP range was selected.
         * If validated, loops through each IP in the range and adds them to the global IpAddresses list
         * If not validated, the background of the last octet is chsnged to light pink.  Stays white if validated
         */
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

        private void Domain_opt_CheckedChanged(object sender, EventArgs e)
        {
            string domain = "";
            domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            feedback_box.AppendText(domain);
            domain_txt.Visible = domain_opt.Checked;
            domain_txt.Text = domain;
        }

        private void Local_opt_CheckedChanged(object sender, EventArgs e)
        {
            domain_txt.Text = "";
        }

        private void Kb_number_txt_Leave(object sender, EventArgs e)
        {
            kb = kb_number_txt.Text;
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

        private void Start_btn_Click(object sender, EventArgs e)
        {
            feedback_box.Clear();
            report.Clear();
            report.Add(new string[] { "IP", "Computer Status", kb + " Notes" });


            if (single_opt.Checked && startIpValidated)
            {
                ipAddresses.Clear();
                ipAddresses.Add(start_ip_txt.Text);
            }

            if (ipAddresses.Count() == 0)
            {
                feedback_box.AppendText("No valid IP to work with.  Verify your IP input." + Environment.NewLine);
                return;
            }


            if (pathToHotfix == null || pathToHotfix == "")
            {
                feedback_box.AppendText("No hotfix selected." + Environment.NewLine);
                return;
            }
            


            if (report_only_chkbox.Checked && (kb != "" || kb != null))
            {
                
                foreach (string address in ipAddresses)
                {
                    feedback_box.AppendText("Checking " + address + Environment.NewLine);
                    string[] response = applicator.ChecForKB(address, kb);
                    feedback_box.AppendText(response[0] + " -- " + response[1] + " -- " + response[2] + Environment.NewLine);
                    report.Add(response);
                }
                feedback_box.AppendText("Done!");
            }
            else
            {
                if(username_txt.Text == null || username_txt.Text == "")
                {
                    feedback_box.AppendText("Username cannot be empty");
                    return;
                }

                if (password_txt.Text == null || password_txt.Text == "")
                {
                    feedback_box.AppendText("Password cannot be empty");
                    return;
                }

                foreach (string address in ipAddresses)
                {
                    string[] response = new string[3];

                    feedback_box.AppendText("Checking " + address + Environment.NewLine);
                    if (kb != "" || kb != null)
                    {
                        response = applicator.ChecForKB(address, kb);

                        if (response[1] == "Success" && response[2] != "Already Installed")
                        {
                            string destination = @"\\" + address + @"\C$\" + hotfix;
                            try
                            {
                                feedback_box.AppendText("Copying the "+kb+" file to " + address + Environment.NewLine);
                                File.Copy(pathToHotfix, destination, true);

                                string domain = (domain_txt.Text == "" || domain_txt.Text == null) ? address : domain_txt.Text;
                                string restartOption = (force_restart_chkbox.Checked) ? "forcerestart" : "norestart";
                                string user = username_txt.Text;
                                string password = password_txt.Text;

                                feedback_box.AppendText("Executing remote install on " + address + Environment.NewLine);
                                feedback_box.AppendText(applicator.InstallHotfix(address, hotfix, restartOption, domain, user, password) + Environment.NewLine);
                                feedback_box.AppendText("Verifying remote install on " + address + Environment.NewLine);
                                response = applicator.ChecForKB(address, kb);
                            }
                            catch (Exception ex)
                            {
                                feedback_box.AppendText("Hotfix file not copied to " + address + Environment.NewLine);
                                Console.WriteLine(ex.Message + Environment.NewLine);
                            }
                        }
                    }
                    feedback_box.AppendText(report[0][0]+" = "+ response[0] + ", " + report[0][1] + " = " + response[1] + ", " + report[0][2] + " = " + response[2] + Environment.NewLine);
                    feedback_box.AppendText(Environment.NewLine);
                    report.Add(response);
                }
                feedback_box.AppendText("Done!" + Environment.NewLine);
            }

        }
    }
}