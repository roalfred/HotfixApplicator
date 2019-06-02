namespace Hotfix_Applicator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ip_section_gb = new System.Windows.Forms.GroupBox();
            this.single_opt = new System.Windows.Forms.RadioButton();
            this.range_opt = new System.Windows.Forms.RadioButton();
            this.list_opt = new System.Windows.Forms.RadioButton();
            this.start_ip_txt = new System.Windows.Forms.TextBox();
            this.start_ip_lbl = new System.Windows.Forms.Label();
            this.end_ip_prefix_txt = new System.Windows.Forms.TextBox();
            this.end_ip_suffix_txt = new System.Windows.Forms.TextBox();
            this.end_ip_lbl = new System.Windows.Forms.Label();
            this.open_ip_list_dialog = new System.Windows.Forms.OpenFileDialog();
            this.open_hotfix_dialog = new System.Windows.Forms.OpenFileDialog();
            this.get_list_btn = new System.Windows.Forms.Button();
            this.ip_list_name_display_box = new System.Windows.Forms.RichTextBox();
            this.hotfix_section_gb = new System.Windows.Forms.GroupBox();
            this.hotfix_name_display_box = new System.Windows.Forms.RichTextBox();
            this.get_hotfix_btn = new System.Windows.Forms.Button();
            this.skip_install_opt = new System.Windows.Forms.RadioButton();
            this.feedback_box = new System.Windows.Forms.RichTextBox();
            this.feedback_section_gb = new System.Windows.Forms.GroupBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ip_section_gb.SuspendLayout();
            this.hotfix_section_gb.SuspendLayout();
            this.feedback_section_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hotfix_section_gb);
            this.splitContainer1.Panel1.Controls.Add(this.ip_section_gb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.feedback_section_gb);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 561);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 0;
            // 
            // ip_section_gb
            // 
            this.ip_section_gb.Controls.Add(this.ip_list_name_display_box);
            this.ip_section_gb.Controls.Add(this.get_list_btn);
            this.ip_section_gb.Controls.Add(this.end_ip_lbl);
            this.ip_section_gb.Controls.Add(this.end_ip_suffix_txt);
            this.ip_section_gb.Controls.Add(this.end_ip_prefix_txt);
            this.ip_section_gb.Controls.Add(this.start_ip_lbl);
            this.ip_section_gb.Controls.Add(this.start_ip_txt);
            this.ip_section_gb.Controls.Add(this.list_opt);
            this.ip_section_gb.Controls.Add(this.range_opt);
            this.ip_section_gb.Controls.Add(this.single_opt);
            this.ip_section_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_section_gb.Location = new System.Drawing.Point(12, 12);
            this.ip_section_gb.Name = "ip_section_gb";
            this.ip_section_gb.Size = new System.Drawing.Size(419, 204);
            this.ip_section_gb.TabIndex = 1;
            this.ip_section_gb.TabStop = false;
            this.ip_section_gb.Text = "IP Section";
            // 
            // single_opt
            // 
            this.single_opt.AutoSize = true;
            this.single_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.single_opt.Location = new System.Drawing.Point(16, 41);
            this.single_opt.Name = "single_opt";
            this.single_opt.Size = new System.Drawing.Size(66, 19);
            this.single_opt.TabIndex = 0;
            this.single_opt.TabStop = true;
            this.single_opt.Text = "Single";
            this.single_opt.UseVisualStyleBackColor = true;
            this.single_opt.CheckedChanged += new System.EventHandler(this.Single_opt_CheckedChanged);
            // 
            // range_opt
            // 
            this.range_opt.AutoSize = true;
            this.range_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_opt.Location = new System.Drawing.Point(160, 41);
            this.range_opt.Name = "range_opt";
            this.range_opt.Size = new System.Drawing.Size(67, 19);
            this.range_opt.TabIndex = 1;
            this.range_opt.TabStop = true;
            this.range_opt.Text = "Range";
            this.range_opt.UseVisualStyleBackColor = true;
            this.range_opt.CheckedChanged += new System.EventHandler(this.Range_opt_CheckedChanged);
            // 
            // list_opt
            // 
            this.list_opt.AutoSize = true;
            this.list_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_opt.Location = new System.Drawing.Point(313, 41);
            this.list_opt.Name = "list_opt";
            this.list_opt.Size = new System.Drawing.Size(48, 19);
            this.list_opt.TabIndex = 2;
            this.list_opt.TabStop = true;
            this.list_opt.Text = "List";
            this.list_opt.UseVisualStyleBackColor = true;
            this.list_opt.CheckedChanged += new System.EventHandler(this.List_opt_CheckedChanged);
            // 
            // start_ip_txt
            // 
            this.start_ip_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_ip_txt.Location = new System.Drawing.Point(61, 94);
            this.start_ip_txt.Name = "start_ip_txt";
            this.start_ip_txt.Size = new System.Drawing.Size(123, 21);
            this.start_ip_txt.TabIndex = 3;
            this.start_ip_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // start_ip_lbl
            // 
            this.start_ip_lbl.AutoSize = true;
            this.start_ip_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_ip_lbl.Location = new System.Drawing.Point(13, 97);
            this.start_ip_lbl.Name = "start_ip_lbl";
            this.start_ip_lbl.Size = new System.Drawing.Size(20, 15);
            this.start_ip_lbl.TabIndex = 4;
            this.start_ip_lbl.Text = "IP";
            // 
            // end_ip_prefix_txt
            // 
            this.end_ip_prefix_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_ip_prefix_txt.Location = new System.Drawing.Point(272, 94);
            this.end_ip_prefix_txt.Name = "end_ip_prefix_txt";
            this.end_ip_prefix_txt.ReadOnly = true;
            this.end_ip_prefix_txt.Size = new System.Drawing.Size(91, 21);
            this.end_ip_prefix_txt.TabIndex = 5;
            this.end_ip_prefix_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.end_ip_prefix_txt.Visible = false;
            // 
            // end_ip_suffix_txt
            // 
            this.end_ip_suffix_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_ip_suffix_txt.Location = new System.Drawing.Point(364, 94);
            this.end_ip_suffix_txt.Name = "end_ip_suffix_txt";
            this.end_ip_suffix_txt.Size = new System.Drawing.Size(32, 21);
            this.end_ip_suffix_txt.TabIndex = 6;
            this.end_ip_suffix_txt.Visible = false;
            // 
            // end_ip_lbl
            // 
            this.end_ip_lbl.AutoSize = true;
            this.end_ip_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_ip_lbl.Location = new System.Drawing.Point(226, 97);
            this.end_ip_lbl.Name = "end_ip_lbl";
            this.end_ip_lbl.Size = new System.Drawing.Size(23, 15);
            this.end_ip_lbl.TabIndex = 7;
            this.end_ip_lbl.Text = "To";
            this.end_ip_lbl.Visible = false;
            // 
            // open_ip_list_dialog
            // 
            this.open_ip_list_dialog.Filter = "Text files (*.txt)|*.txt";
            this.open_ip_list_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_ip_list_dialog_FileOk);
            // 
            // open_hotfix_dialog
            // 
            this.open_hotfix_dialog.Filter = "Microsoft Updates (*.msu)|*.msu";
            // 
            // get_list_btn
            // 
            this.get_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_list_btn.Location = new System.Drawing.Point(16, 135);
            this.get_list_btn.Name = "get_list_btn";
            this.get_list_btn.Size = new System.Drawing.Size(75, 23);
            this.get_list_btn.TabIndex = 8;
            this.get_list_btn.Text = "Get List";
            this.get_list_btn.UseVisualStyleBackColor = true;
            this.get_list_btn.Visible = false;
            this.get_list_btn.Click += new System.EventHandler(this.Get_list_btn_Click);
            // 
            // ip_list_name_display_box
            // 
            this.ip_list_name_display_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_list_name_display_box.Location = new System.Drawing.Point(97, 135);
            this.ip_list_name_display_box.Name = "ip_list_name_display_box";
            this.ip_list_name_display_box.ReadOnly = true;
            this.ip_list_name_display_box.Size = new System.Drawing.Size(299, 44);
            this.ip_list_name_display_box.TabIndex = 0;
            this.ip_list_name_display_box.Text = "No file selected.  Click Get List to select one.";
            this.ip_list_name_display_box.Visible = false;
            // 
            // hotfix_section_gb
            // 
            this.hotfix_section_gb.Controls.Add(this.skip_install_opt);
            this.hotfix_section_gb.Controls.Add(this.hotfix_name_display_box);
            this.hotfix_section_gb.Controls.Add(this.get_hotfix_btn);
            this.hotfix_section_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotfix_section_gb.Location = new System.Drawing.Point(12, 222);
            this.hotfix_section_gb.Name = "hotfix_section_gb";
            this.hotfix_section_gb.Size = new System.Drawing.Size(419, 141);
            this.hotfix_section_gb.TabIndex = 9;
            this.hotfix_section_gb.TabStop = false;
            this.hotfix_section_gb.Text = "Hotfix Section";
            // 
            // hotfix_name_display_box
            // 
            this.hotfix_name_display_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotfix_name_display_box.Location = new System.Drawing.Point(97, 31);
            this.hotfix_name_display_box.Name = "hotfix_name_display_box";
            this.hotfix_name_display_box.ReadOnly = true;
            this.hotfix_name_display_box.Size = new System.Drawing.Size(299, 44);
            this.hotfix_name_display_box.TabIndex = 0;
            this.hotfix_name_display_box.Text = "No file selected.  Click Hotfix to select one.";
            // 
            // get_hotfix_btn
            // 
            this.get_hotfix_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_hotfix_btn.Location = new System.Drawing.Point(16, 31);
            this.get_hotfix_btn.Name = "get_hotfix_btn";
            this.get_hotfix_btn.Size = new System.Drawing.Size(75, 23);
            this.get_hotfix_btn.TabIndex = 8;
            this.get_hotfix_btn.Text = "Hotfix";
            this.get_hotfix_btn.UseVisualStyleBackColor = true;
            this.get_hotfix_btn.Click += new System.EventHandler(this.Get_hotfix_btn_Click);
            // 
            // skip_install_opt
            // 
            this.skip_install_opt.AutoSize = true;
            this.skip_install_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip_install_opt.Location = new System.Drawing.Point(16, 93);
            this.skip_install_opt.Name = "skip_install_opt";
            this.skip_install_opt.Size = new System.Drawing.Size(175, 19);
            this.skip_install_opt.TabIndex = 9;
            this.skip_install_opt.TabStop = true;
            this.skip_install_opt.Text = "Skip If Already Installed";
            this.skip_install_opt.UseVisualStyleBackColor = true;
            // 
            // feedback_box
            // 
            this.feedback_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_box.Location = new System.Drawing.Point(16, 41);
            this.feedback_box.Name = "feedback_box";
            this.feedback_box.ReadOnly = true;
            this.feedback_box.Size = new System.Drawing.Size(516, 446);
            this.feedback_box.TabIndex = 0;
            this.feedback_box.Text = "";
            // 
            // feedback_section_gb
            // 
            this.feedback_section_gb.Controls.Add(this.feedback_box);
            this.feedback_section_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_section_gb.Location = new System.Drawing.Point(14, 12);
            this.feedback_section_gb.Name = "feedback_section_gb";
            this.feedback_section_gb.Size = new System.Drawing.Size(547, 493);
            this.feedback_section_gb.TabIndex = 1;
            this.feedback_section_gb.TabStop = false;
            this.feedback_section_gb.Text = "Feedback Section";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hotfix Applicator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ip_section_gb.ResumeLayout(false);
            this.ip_section_gb.PerformLayout();
            this.hotfix_section_gb.ResumeLayout(false);
            this.hotfix_section_gb.PerformLayout();
            this.feedback_section_gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox ip_section_gb;
        private System.Windows.Forms.RadioButton single_opt;
        private System.Windows.Forms.RadioButton range_opt;
        private System.Windows.Forms.RadioButton list_opt;
        private System.Windows.Forms.TextBox start_ip_txt;
        private System.Windows.Forms.Label start_ip_lbl;
        private System.Windows.Forms.TextBox end_ip_suffix_txt;
        private System.Windows.Forms.TextBox end_ip_prefix_txt;
        private System.Windows.Forms.Label end_ip_lbl;
        private System.Windows.Forms.OpenFileDialog open_ip_list_dialog;
        private System.Windows.Forms.OpenFileDialog open_hotfix_dialog;
        private System.Windows.Forms.Button get_list_btn;
        private System.Windows.Forms.RichTextBox ip_list_name_display_box;
        private System.Windows.Forms.GroupBox hotfix_section_gb;
        private System.Windows.Forms.RichTextBox hotfix_name_display_box;
        private System.Windows.Forms.Button get_hotfix_btn;
        private System.Windows.Forms.RadioButton skip_install_opt;
        private System.Windows.Forms.GroupBox feedback_section_gb;
        private System.Windows.Forms.RichTextBox feedback_box;
    }
}

