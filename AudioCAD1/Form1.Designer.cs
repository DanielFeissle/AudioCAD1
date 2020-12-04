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
            this.components = new System.ComponentModel.Container();
            this.mnu_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_openSentence = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save_sentence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.resetMasterConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Despacer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_standaloneAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_audioLibrary = new System.Windows.Forms.OpenFileDialog();
            this.dlg_TextSave = new System.Windows.Forms.SaveFileDialog();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.rtx_history = new System.Windows.Forms.RichTextBox();
            this.lst_select = new System.Windows.Forms.ListBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_stringDiff = new System.Windows.Forms.Label();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tmr_progressPlayer = new System.Windows.Forms.Timer(this.components);
            this.txt_progress = new System.Windows.Forms.TextBox();
            this.lbl_runHist = new System.Windows.Forms.Label();
            this.dlg_TextOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlg_ExportProc = new System.Windows.Forms.SaveFileDialog();
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
            this.mnu_main.Enter += new System.EventHandler(this.mnu_main_Enter);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.btn_openSentence,
            this.btn_save_sentence,
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 6);
            // 
            // btn_openSentence
            // 
            this.btn_openSentence.Name = "btn_openSentence";
            this.btn_openSentence.Size = new System.Drawing.Size(147, 30);
            this.btn_openSentence.Text = "Open";
            this.btn_openSentence.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btn_save_sentence
            // 
            this.btn_save_sentence.Name = "btn_save_sentence";
            this.btn_save_sentence.Size = new System.Drawing.Size(147, 30);
            this.btn_save_sentence.Text = "Save";
            this.btn_save_sentence.Click += new System.EventHandler(this.btn_save_sentence_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem4,
            this.resetMasterConfToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.clearToolStripMenuItem.Text = "Audio Library";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(234, 6);
            // 
            // resetMasterConfToolStripMenuItem
            // 
            this.resetMasterConfToolStripMenuItem.Name = "resetMasterConfToolStripMenuItem";
            this.resetMasterConfToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.resetMasterConfToolStripMenuItem.Text = "Reset master conf";
            this.resetMasterConfToolStripMenuItem.Click += new System.EventHandler(this.resetMasterConfToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Despacer,
            this.btn_standaloneAudio});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // btn_Despacer
            // 
            this.btn_Despacer.Name = "btn_Despacer";
            this.btn_Despacer.Size = new System.Drawing.Size(286, 30);
            this.btn_Despacer.Text = "DeSpacer";
            this.btn_Despacer.Click += new System.EventHandler(this.deSpacerToolStripMenuItem_Click);
            // 
            // btn_standaloneAudio
            // 
            this.btn_standaloneAudio.Name = "btn_standaloneAudio";
            this.btn_standaloneAudio.Size = new System.Drawing.Size(286, 30);
            this.btn_standaloneAudio.Text = "Standalone_AudioPlayer";
            this.btn_standaloneAudio.Click += new System.EventHandler(this.audioPlayerToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dlg_audioLibrary
            // 
            this.dlg_audioLibrary.FileName = "openFileDialog1";
            // 
            // dlg_TextSave
            // 
            this.dlg_TextSave.Filter = "Text files|*.txt|All files|*.*";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(12, 544);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(1129, 26);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
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
            // rtx_history
            // 
            this.rtx_history.DetectUrls = false;
            this.rtx_history.Location = new System.Drawing.Point(12, 78);
            this.rtx_history.Name = "rtx_history";
            this.rtx_history.ReadOnly = true;
            this.rtx_history.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtx_history.Size = new System.Drawing.Size(1234, 444);
            this.rtx_history.TabIndex = 3;
            this.rtx_history.Text = "";
            // 
            // lst_select
            // 
            this.lst_select.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_select.FormattingEnabled = true;
            this.lst_select.ItemHeight = 19;
            this.lst_select.Location = new System.Drawing.Point(12, 626);
            this.lst_select.Name = "lst_select";
            this.lst_select.Size = new System.Drawing.Size(1234, 289);
            this.lst_select.TabIndex = 5;
            this.lst_select.DoubleClick += new System.EventHandler(this.lst_select_DoubleClick_1);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(1147, 544);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(99, 58);
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
            // tmr_progressPlayer
            // 
            this.tmr_progressPlayer.Tick += new System.EventHandler(this.tmr_progressPlayer_Tick);
            // 
            // txt_progress
            // 
            this.txt_progress.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_progress.Location = new System.Drawing.Point(12, 576);
            this.txt_progress.Name = "txt_progress";
            this.txt_progress.Size = new System.Drawing.Size(1129, 26);
            this.txt_progress.TabIndex = 10;
            // 
            // lbl_runHist
            // 
            this.lbl_runHist.AutoSize = true;
            this.lbl_runHist.Location = new System.Drawing.Point(12, 55);
            this.lbl_runHist.Name = "lbl_runHist";
            this.lbl_runHist.Size = new System.Drawing.Size(92, 20);
            this.lbl_runHist.TabIndex = 11;
            this.lbl_runHist.Text = "Run History";
            // 
            // dlg_TextOpen
            // 
            this.dlg_TextOpen.Filter = "Text files|*.txt|All files|*.*";
            // 
            // dlg_ExportProc
            // 
            this.dlg_ExportProc.Filter = "VBS files|*.vbs|All files|*.*";
            this.dlg_ExportProc.Title = "Export As...";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 968);
            this.Controls.Add(this.lbl_runHist);
            this.Controls.Add(this.txt_progress);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.lbl_stringDiff);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lst_select);
            this.Controls.Add(this.rtx_history);
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
        private System.Windows.Forms.SaveFileDialog dlg_TextSave;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.RichTextBox rtx_history;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btn_openSentence;
        private System.Windows.Forms.ToolStripMenuItem btn_save_sentence;
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
        private System.Windows.Forms.Timer tmr_progressPlayer;
        private System.Windows.Forms.TextBox txt_progress;
        private System.Windows.Forms.Label lbl_runHist;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_standaloneAudio;
        private System.Windows.Forms.ToolStripMenuItem btn_Despacer;
        private System.Windows.Forms.OpenFileDialog dlg_TextOpen;
        private System.Windows.Forms.SaveFileDialog dlg_ExportProc;
    }
}

