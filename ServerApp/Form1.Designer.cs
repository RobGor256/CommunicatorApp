namespace ServerApp
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.btnRun = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstConnectedClients = new System.Windows.Forms.ListBox();
            this.lblConnctedClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.txtServerIP, "txtServerIP");
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.ReadOnly = true;
            // 
            // lblServer
            // 
            resources.ApplyResources(this.lblServer, "lblServer");
            this.lblServer.Name = "lblServer";
            this.lblServer.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtConsole
            // 
            resources.ApplyResources(this.txtConsole, "txtConsole");
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            resources.ApplyResources(this.txtMsg, "txtMsg");
            this.txtMsg.Name = "txtMsg";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lstConnectedClients
            // 
            this.lstConnectedClients.FormattingEnabled = true;
            resources.ApplyResources(this.lstConnectedClients, "lstConnectedClients");
            this.lstConnectedClients.Name = "lstConnectedClients";
            // 
            // lblConnctedClients
            // 
            resources.ApplyResources(this.lblConnctedClients, "lblConnctedClients");
            this.lblConnctedClients.Name = "lblConnctedClients";
            // 
            // Server
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnctedClients);
            this.Controls.Add(this.lstConnectedClients);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnRun);
            this.MinimizeBox = false;
            this.Name = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRun;
        private TextBox txtServerIP;
        private Label lblServer;
        private TextBox txtConsole;
        private Button btnSend;
        private TextBox txtMsg;
        private Label lblMessage;
        private ListBox lstConnectedClients;
        private Label lblConnctedClients;
    }
}