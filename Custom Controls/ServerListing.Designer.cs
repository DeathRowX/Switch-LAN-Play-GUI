
namespace Switch_LAN_Play_GUI.Custom_Controls
{
    partial class ServerListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bServerConnect = new System.Windows.Forms.Button();
            this.lServerAddress = new System.Windows.Forms.Label();
            this.pServerPlatform = new System.Windows.Forms.PictureBox();
            this.pServerFlag = new System.Windows.Forms.PictureBox();
            this.lServerLatency = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pServerPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServerFlag)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bServerConnect
            // 
            this.bServerConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bServerConnect.Location = new System.Drawing.Point(427, 6);
            this.bServerConnect.Name = "bServerConnect";
            this.bServerConnect.Size = new System.Drawing.Size(60, 23);
            this.bServerConnect.TabIndex = 0;
            this.bServerConnect.Text = "Connect";
            this.bServerConnect.UseVisualStyleBackColor = true;
            // 
            // lServerAddress
            // 
            this.lServerAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lServerAddress.Location = new System.Drawing.Point(3, 6);
            this.lServerAddress.Name = "lServerAddress";
            this.lServerAddress.Size = new System.Drawing.Size(284, 23);
            this.lServerAddress.TabIndex = 1;
            this.lServerAddress.Text = "switch-lanyplay-de.ddns.net:11451";
            this.lServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pServerPlatform
            // 
            this.pServerPlatform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pServerPlatform.Location = new System.Drawing.Point(396, 6);
            this.pServerPlatform.Name = "pServerPlatform";
            this.pServerPlatform.Size = new System.Drawing.Size(25, 23);
            this.pServerPlatform.TabIndex = 2;
            this.pServerPlatform.TabStop = false;
            // 
            // pServerFlag
            // 
            this.pServerFlag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pServerFlag.Location = new System.Drawing.Point(365, 6);
            this.pServerFlag.Name = "pServerFlag";
            this.pServerFlag.Size = new System.Drawing.Size(25, 23);
            this.pServerFlag.TabIndex = 3;
            this.pServerFlag.TabStop = false;
            // 
            // lServerLatency
            // 
            this.lServerLatency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lServerLatency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lServerLatency.Location = new System.Drawing.Point(299, 6);
            this.lServerLatency.Name = "lServerLatency";
            this.lServerLatency.Size = new System.Drawing.Size(60, 23);
            this.lServerLatency.TabIndex = 1;
            this.lServerLatency.Text = "[ms]ms";
            this.lServerLatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bServerConnect);
            this.panel1.Controls.Add(this.lServerAddress);
            this.panel1.Controls.Add(this.lServerLatency);
            this.panel1.Controls.Add(this.pServerFlag);
            this.panel1.Controls.Add(this.pServerPlatform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 37);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // ServerListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ServerListing";
            this.Size = new System.Drawing.Size(492, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pServerPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServerFlag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button bServerConnect;
        public System.Windows.Forms.Label lServerAddress;
        public System.Windows.Forms.PictureBox pServerPlatform;
        public System.Windows.Forms.PictureBox pServerFlag;
        public System.Windows.Forms.Label lServerLatency;
    }
}
