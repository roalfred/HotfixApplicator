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

            end_ip_lbl.Visible = true;
            end_ip_prefix_txt.Visible = true;
            end_ip_suffix_txt.Visible = true;

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
            String fileName, fileWithPath, line;
            List<Byte[]> octets = new List<byte[]>();
            List<String> addressList = new List<string>();
            Validator validator = new Validator();
            TextReader reader;

            fileName = open_ip_list_dialog.SafeFileName;
            fileWithPath = open_ip_list_dialog.FileName;
            reader = new StreamReader(fileWithPath);

            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                octets = validator.ValidateIP(line);

                if (octets.Count == 0)
                {
                    octets.Clear();
                    feedback_box.AppendText(line + "is not a valid IP.  Please fix the list and retry import." +Environment.NewLine);
                    break;
                }
                feedback_box.AppendText(line + Environment.NewLine);
            }
            reader.Close();
            ip_list_name_display_box.Text = fileName;
        }
    }
}
