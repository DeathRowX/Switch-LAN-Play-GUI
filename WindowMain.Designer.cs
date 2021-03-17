
namespace Switch_LAN_Play_GUI
{
    partial class WindowMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bLogsClear = new System.Windows.Forms.Button();
            this.bLogsExport = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsoleLog = new System.Windows.Forms.TabPage();
            this.tabErrorLog = new System.Windows.Forms.TabPage();
            this.logConsole = new System.Windows.Forms.RichTextBox();
            this.logError = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsoleLog.SuspendLayout();
            this.tabErrorLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.bExit);
            this.splitContainer1.Panel2.Controls.Add(this.bLogsExport);
            this.splitContainer1.Panel2.Controls.Add(this.bLogsClear);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(913, 516);
            this.splitContainer1.SplitterDistance = 459;
            this.splitContainer1.TabIndex = 1;
            // 
            // bLogsClear
            // 
            this.bLogsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLogsClear.Location = new System.Drawing.Point(3, 490);
            this.bLogsClear.Name = "bLogsClear";
            this.bLogsClear.Size = new System.Drawing.Size(75, 23);
            this.bLogsClear.TabIndex = 0;
            this.bLogsClear.Text = "Clear Logs";
            this.bLogsClear.UseVisualStyleBackColor = true;
            // 
            // bLogsExport
            // 
            this.bLogsExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLogsExport.Location = new System.Drawing.Point(84, 490);
            this.bLogsExport.Name = "bLogsExport";
            this.bLogsExport.Size = new System.Drawing.Size(75, 23);
            this.bLogsExport.TabIndex = 1;
            this.bLogsExport.Text = "Export Logs";
            this.bLogsExport.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.Location = new System.Drawing.Point(372, 490);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabConsoleLog);
            this.tabControl1.Controls.Add(this.tabErrorLog);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 481);
            this.tabControl1.TabIndex = 3;
            // 
            // tabConsoleLog
            // 
            this.tabConsoleLog.Controls.Add(this.logConsole);
            this.tabConsoleLog.Location = new System.Drawing.Point(4, 22);
            this.tabConsoleLog.Name = "tabConsoleLog";
            this.tabConsoleLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsoleLog.Size = new System.Drawing.Size(436, 455);
            this.tabConsoleLog.TabIndex = 0;
            this.tabConsoleLog.Text = "Console";
            this.tabConsoleLog.UseVisualStyleBackColor = true;
            // 
            // tabErrorLog
            // 
            this.tabErrorLog.Controls.Add(this.logError);
            this.tabErrorLog.Location = new System.Drawing.Point(4, 22);
            this.tabErrorLog.Name = "tabErrorLog";
            this.tabErrorLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrorLog.Size = new System.Drawing.Size(436, 455);
            this.tabErrorLog.TabIndex = 1;
            this.tabErrorLog.Text = "Errors";
            this.tabErrorLog.UseVisualStyleBackColor = true;
            // 
            // logConsole
            // 
            this.logConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logConsole.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logConsole.Location = new System.Drawing.Point(3, 3);
            this.logConsole.Name = "logConsole";
            this.logConsole.ReadOnly = true;
            this.logConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logConsole.Size = new System.Drawing.Size(430, 449);
            this.logConsole.TabIndex = 0;
            this.logConsole.Text = "";
            this.logConsole.WordWrap = false;
            // 
            // logError
            // 
            this.logError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logError.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logError.Location = new System.Drawing.Point(3, 3);
            this.logError.Name = "logError";
            this.logError.ReadOnly = true;
            this.logError.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logError.Size = new System.Drawing.Size(430, 449);
            this.logError.TabIndex = 0;
            this.logError.Text = "";
            this.logError.WordWrap = false;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "WindowMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch LAN Play GUI";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabConsoleLog.ResumeLayout(false);
            this.tabErrorLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsoleLog;
        private System.Windows.Forms.TabPage tabErrorLog;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bLogsExport;
        private System.Windows.Forms.Button bLogsClear;
        public System.Windows.Forms.RichTextBox logConsole;
        public System.Windows.Forms.RichTextBox logError;
    }
}

