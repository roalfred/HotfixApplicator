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
            this.start_btn = new System.Windows.Forms.Button();
            this.hotfix_section_gb = new System.Windows.Forms.GroupBox();
            this.kb_number_lbl = new System.Windows.Forms.Label();
            this.kb_number_txt = new System.Windows.Forms.TextBox();
            this.skip_if_present_chkbox = new System.Windows.Forms.CheckBox();
            this.report_only_chkbox = new System.Windows.Forms.CheckBox();
            this.hotfix_name_display_box = new System.Windows.Forms.RichTextBox();
            this.get_hotfix_btn = new System.Windows.Forms.Button();
            this.ip_section_gb = new System.Windows.Forms.GroupBox();
            this.ip_list_name_display_box = new System.Windows.Forms.RichTextBox();
            this.get_list_btn = new System.Windows.Forms.Button();
            this.end_ip_lbl = new System.Windows.Forms.Label();
            this.end_ip_suffix_txt = new System.Windows.Forms.TextBox();
            this.end_ip_prefix_txt = new System.Windows.Forms.TextBox();
            this.start_ip_lbl = new System.Windows.Forms.Label();
            this.start_ip_txt = new System.Windows.Forms.TextBox();
            this.list_opt = new System.Windows.Forms.RadioButton();
            this.range_opt = new System.Windows.Forms.RadioButton();
            this.single_opt = new System.Windows.Forms.RadioButton();
            this.clear_btn = new System.Windows.Forms.Button();
            this.feedback_section_gb = new System.Windows.Forms.GroupBox();
            this.feedback_box = new System.Windows.Forms.RichTextBox();
            this.open_ip_list_dialog = new System.Windows.Forms.OpenFileDialog();
            this.open_hotfix_dialog = new System.Windows.Forms.OpenFileDialog();
            this.force_restart_chkbox = new System.Windows.Forms.CheckBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.hotfix_section_gb.SuspendLayout();
            this.ip_section_gb.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.start_btn);
            this.splitContainer1.Panel1.Controls.Add(this.hotfix_section_gb);
            this.splitContainer1.Panel1.Controls.Add(this.ip_section_gb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clear_btn);
            this.splitContainer1.Panel2.Controls.Add(this.feedback_section_gb);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 561);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(28, 511);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 10;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // hotfix_section_gb
            // 
            this.hotfix_section_gb.Controls.Add(this.force_restart_chkbox);
            this.hotfix_section_gb.Controls.Add(this.kb_number_lbl);
            this.hotfix_section_gb.Controls.Add(this.kb_number_txt);
            this.hotfix_section_gb.Controls.Add(this.skip_if_present_chkbox);
            this.hotfix_section_gb.Controls.Add(this.report_only_chkbox);
            this.hotfix_section_gb.Controls.Add(this.hotfix_name_display_box);
            this.hotfix_section_gb.Controls.Add(this.get_hotfix_btn);
            this.hotfix_section_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotfix_section_gb.Location = new System.Drawing.Point(12, 222);
            this.hotfix_section_gb.Name = "hotfix_section_gb";
            this.hotfix_section_gb.Size = new System.Drawing.Size(419, 209);
            this.hotfix_section_gb.TabIndex = 9;
            this.hotfix_section_gb.TabStop = false;
            this.hotfix_section_gb.Text = "Hotfix Section";
            // 
            // kb_number_lbl
            // 
            this.kb_number_lbl.AutoSize = true;
            this.kb_number_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kb_number_lbl.Location = new System.Drawing.Point(13, 171);
            this.kb_number_lbl.Name = "kb_number_lbl";
            this.kb_number_lbl.Size = new System.Drawing.Size(80, 15);
            this.kb_number_lbl.TabIndex = 13;
            this.kb_number_lbl.Text = "KB Number";
            this.kb_number_lbl.Visible = false;
            // 
            // kb_number_txt
            // 
            this.kb_number_txt.Location = new System.Drawing.Point(97, 168);
            this.kb_number_txt.Name = "kb_number_txt";
            this.kb_number_txt.Size = new System.Drawing.Size(148, 23);
            this.kb_number_txt.TabIndex = 12;
            this.kb_number_txt.Visible = false;
            // 
            // skip_if_present_chkbox
            // 
            this.skip_if_present_chkbox.AutoSize = true;
            this.skip_if_present_chkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip_if_present_chkbox.Location = new System.Drawing.Point(16, 134);
            this.skip_if_present_chkbox.Name = "skip_if_present_chkbox";
            this.skip_if_present_chkbox.Size = new System.Drawing.Size(176, 19);
            this.skip_if_present_chkbox.TabIndex = 11;
            this.skip_if_present_chkbox.Text = "Skip If Already Installed";
            this.skip_if_present_chkbox.UseVisualStyleBackColor = true;
            this.skip_if_present_chkbox.CheckedChanged += new System.EventHandler(this.Skip_if_present_chkbox_CheckedChanged);
            // 
            // report_only_chkbox
            // 
            this.report_only_chkbox.AutoSize = true;
            this.report_only_chkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_only_chkbox.Location = new System.Drawing.Point(16, 101);
            this.report_only_chkbox.Name = "report_only_chkbox";
            this.report_only_chkbox.Size = new System.Drawing.Size(202, 19);
            this.report_only_chkbox.TabIndex = 10;
            this.report_only_chkbox.Text = "Report Only (Do Not Install)";
            this.report_only_chkbox.UseVisualStyleBackColor = true;
            this.report_only_chkbox.CheckedChanged += new System.EventHandler(this.Report_only_chkbox_CheckedChanged);
            // 
            // hotfix_name_display_box
            // 
            this.hotfix_name_display_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotfix_name_display_box.Location = new System.Drawing.Point(97, 30);
            this.hotfix_name_display_box.Name = "hotfix_name_display_box";
            this.hotfix_name_display_box.ReadOnly = true;
            this.hotfix_name_display_box.Size = new System.Drawing.Size(299, 44);
            this.hotfix_name_display_box.TabIndex = 0;
            this.hotfix_name_display_box.Text = "No file selected.  Click Hotfix to select one.";
            // 
            // get_hotfix_btn
            // 
            this.get_hotfix_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_hotfix_btn.Location = new System.Drawing.Point(16, 30);
            this.get_hotfix_btn.Name = "get_hotfix_btn";
            this.get_hotfix_btn.Size = new System.Drawing.Size(75, 23);
            this.get_hotfix_btn.TabIndex = 8;
            this.get_hotfix_btn.Text = "Hotfix";
            this.get_hotfix_btn.UseVisualStyleBackColor = true;
            this.get_hotfix_btn.Click += new System.EventHandler(this.Get_hotfix_btn_Click);
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
            // end_ip_suffix_txt
            // 
            this.end_ip_suffix_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_ip_suffix_txt.Location = new System.Drawing.Point(364, 94);
            this.end_ip_suffix_txt.Name = "end_ip_suffix_txt";
            this.end_ip_suffix_txt.Size = new System.Drawing.Size(32, 21);
            this.end_ip_suffix_txt.TabIndex = 6;
            this.end_ip_suffix_txt.Visible = false;
            this.end_ip_suffix_txt.Leave += new System.EventHandler(this.End_ip_suffix_txt_Leave);
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
            // start_ip_txt
            // 
            this.start_ip_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_ip_txt.Location = new System.Drawing.Point(61, 94);
            this.start_ip_txt.Name = "start_ip_txt";
            this.start_ip_txt.Size = new System.Drawing.Size(123, 21);
            this.start_ip_txt.TabIndex = 3;
            this.start_ip_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.start_ip_txt.Leave += new System.EventHandler(this.Start_ip_txt_Leave);
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
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(30, 511);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
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
            // open_ip_list_dialog
            // 
            this.open_ip_list_dialog.Filter = "Text files (*.txt)|*.txt";
            this.open_ip_list_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_ip_list_dialog_FileOk);
            // 
            // open_hotfix_dialog
            // 
            this.open_hotfix_dialog.Filter = "Microsoft Updates (*.msu)|*.msu";
            this.open_hotfix_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_hotfix_dialog_FileOk);
            // 
            // force_restart_chkbox
            // 
            this.force_restart_chkbox.AutoSize = true;
            this.force_restart_chkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.force_restart_chkbox.Location = new System.Drawing.Point(284, 101);
            this.force_restart_chkbox.Name = "force_restart_chkbox";
            this.force_restart_chkbox.Size = new System.Drawing.Size(112, 19);
            this.force_restart_chkbox.TabIndex = 14;
            this.force_restart_chkbox.Text = "Force Restart";
            this.force_restart_chkbox.UseVisualStyleBackColor = true;
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
            this.hotfix_section_gb.ResumeLayout(false);
            this.hotfix_section_gb.PerformLayout();
            this.ip_section_gb.ResumeLayout(false);
            this.ip_section_gb.PerformLayout();
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
        private System.Windows.Forms.GroupBox feedback_section_gb;
        private System.Windows.Forms.RichTextBox feedback_box;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox report_only_chkbox;
        private System.Windows.Forms.CheckBox skip_if_present_chkbox;
        private System.Windows.Forms.TextBox kb_number_txt;
        private System.Windows.Forms.Label kb_number_lbl;
        private System.Windows.Forms.CheckBox force_restart_chkbox;
    }
}

