namespace AudioCAD1
{
    partial class frm_main
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
            this.mnu_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.resetMasterConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_audioLibrary = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.rtx_term_search = new System.Windows.Forms.RichTextBox();
            this.rtx_stagement = new System.Windows.Forms.RichTextBox();
            this.lst_select = new System.Windows.Forms.ListBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_stringDiff = new System.Windows.Forms.Label();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.mnu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_main
            // 
            this.mnu_main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnu_main.Location = new System.Drawing.Point(0, 0);
            this.mnu_main.Name = "mnu_main";
            this.mnu_main.Size = new System.Drawing.Size(1258, 33);
            this.mnu_main.TabIndex = 0;
            this.mnu_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(249, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem4,
            this.resetMasterConfToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.clearToolStripMenuItem.Text = "Audio Library";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(249, 6);
            // 
            // resetMasterConfToolStripMenuItem
            // 
            this.resetMasterConfToolStripMenuItem.Name = "resetMasterConfToolStripMenuItem";
            this.resetMasterConfToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.resetMasterConfToolStripMenuItem.Text = "Reset master conf";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dlg_audioLibrary
            // 
            this.dlg_audioLibrary.FileName = "openFileDialog1";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 544);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(1234, 26);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(536, 939);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(144, 20);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Active search start:";
            // 
            // rtx_term_search
            // 
            this.rtx_term_search.Location = new System.Drawing.Point(12, 626);
            this.rtx_term_search.Name = "rtx_term_search";
            this.rtx_term_search.Size = new System.Drawing.Size(1234, 306);
            this.rtx_term_search.TabIndex = 3;
            this.rtx_term_search.Text = "";
            // 
            // rtx_stagement
            // 
            this.rtx_stagement.Location = new System.Drawing.Point(12, 576);
            this.rtx_stagement.Name = "rtx_stagement";
            this.rtx_stagement.Size = new System.Drawing.Size(1234, 39);
            this.rtx_stagement.TabIndex = 4;
            this.rtx_stagement.Text = "";
            this.rtx_stagement.TextChanged += new System.EventHandler(this.rtx_stagement_TextChanged);
            // 
            // lst_select
            // 
            this.lst_select.FormattingEnabled = true;
            this.lst_select.ItemHeight = 20;
            this.lst_select.Location = new System.Drawing.Point(12, 626);
            this.lst_select.Name = "lst_select";
            this.lst_select.Size = new System.Drawing.Size(1234, 304);
            this.lst_select.TabIndex = 5;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(849, 288);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(116, 44);
            this.btn_play.TabIndex = 6;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_stringDiff
            // 
            this.lbl_stringDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_stringDiff.AutoSize = true;
            this.lbl_stringDiff.Location = new System.Drawing.Point(12, 939);
            this.lbl_stringDiff.Name = "lbl_stringDiff";
            this.lbl_stringDiff.Size = new System.Drawing.Size(100, 20);
            this.lbl_stringDiff.TabIndex = 7;
            this.lbl_stringDiff.Text = "Difference: 0";
            // 
            // lbl_debug
            // 
            this.lbl_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Location = new System.Drawing.Point(169, 939);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(100, 20);
            this.lbl_debug.TabIndex = 8;
            this.lbl_debug.Text = "Difference: 0";
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork_1);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(1089, 939);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(86, 20);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Status: OK";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 968);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.lbl_stringDiff);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lst_select);
            this.Controls.Add(this.rtx_stagement);
            this.Controls.Add(this.rtx_term_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.mnu_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnu_main;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Audio-";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.mnu_main.ResumeLayout(false);
            this.mnu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_main;
        private System.Windows.Forms.OpenFileDialog dlg_audioLibrary;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.RichTextBox rtx_term_search;
        private System.Windows.Forms.RichTextBox rtx_stagement;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lst_select;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem resetMasterConfToolStripMenuItem;
        private System.Windows.Forms.Label lbl_stringDiff;
        private System.Windows.Forms.Label lbl_debug;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lbl_status;
    }
}

