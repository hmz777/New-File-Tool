namespace NewFileTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Filename = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CreateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.StatusText = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SyntaxButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filename
            // 
            this.Filename.Depth = 0;
            this.Filename.Hint = "File Name";
            this.Filename.Location = new System.Drawing.Point(12, 87);
            this.Filename.MaxLength = 32767;
            this.Filename.MouseState = MaterialSkin.MouseState.HOVER;
            this.Filename.Name = "Filename";
            this.Filename.PasswordChar = '\0';
            this.Filename.SelectedText = "";
            this.Filename.SelectionLength = 0;
            this.Filename.SelectionStart = 0;
            this.Filename.Size = new System.Drawing.Size(358, 23);
            this.Filename.TabIndex = 0;
            this.Filename.TabStop = false;
            this.Filename.UseSystemPasswordChar = false;
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateButton.Depth = 0;
            this.CreateButton.Icon = null;
            this.CreateButton.Location = new System.Drawing.Point(420, 80);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Primary = false;
            this.CreateButton.Size = new System.Drawing.Size(71, 36);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Depth = 0;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(502, 80);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = false;
            this.CloseButton.Size = new System.Drawing.Size(63, 36);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.BackColor = System.Drawing.Color.Transparent;
            this.StatusText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.Color.Red;
            this.StatusText.Location = new System.Drawing.Point(12, 113);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 20);
            this.StatusText.TabIndex = 3;
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.BalloonTipText = "New File Tool is active!";
            this.TrayIcon.BalloonTipTitle = "New File Tool";
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "New File Tool is active!";
            this.TrayIcon.Visible = true;
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayShow,
            this.TrayExit});
            this.TrayContextMenu.Name = "TrayContextMenu";
            this.TrayContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // TrayShow
            // 
            this.TrayShow.Name = "TrayShow";
            this.TrayShow.Size = new System.Drawing.Size(103, 22);
            this.TrayShow.Text = "Show";
            this.TrayShow.Click += new System.EventHandler(this.TrayShow_Click);
            // 
            // TrayExit
            // 
            this.TrayExit.Name = "TrayExit";
            this.TrayExit.Size = new System.Drawing.Size(103, 22);
            this.TrayExit.Text = "Exit";
            this.TrayExit.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SyntaxButton
            // 
            this.SyntaxButton.AutoSize = true;
            this.SyntaxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SyntaxButton.Depth = 0;
            this.SyntaxButton.Icon = null;
            this.SyntaxButton.Location = new System.Drawing.Point(381, 80);
            this.SyntaxButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SyntaxButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SyntaxButton.Name = "SyntaxButton";
            this.SyntaxButton.Primary = false;
            this.SyntaxButton.Size = new System.Drawing.Size(28, 36);
            this.SyntaxButton.TabIndex = 4;
            this.SyntaxButton.Text = "?";
            this.HelpToolTip.SetToolTip(this.SyntaxButton, "Syntax:\r\nFilename only: \"filename.ext\"\r\nPath: \"dir\\dir\\filename.ext\"\r\nFile with f" +
        "lags: \"filename.ext > -h -s- r\"\r\nPath with flags: \"dir\\dir\\filename.ext > -h -s " +
        "-r\"");
            this.SyntaxButton.UseVisualStyleBackColor = true;
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.AutoPopDelay = 10000;
            this.HelpToolTip.InitialDelay = 100;
            this.HelpToolTip.IsBalloon = true;
            this.HelpToolTip.ReshowDelay = 100;
            this.HelpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HelpToolTip.ToolTipTitle = "Help";
            // 
            // MainForm
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(579, 142);
            this.Controls.Add(this.SyntaxButton);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Filename);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New File Tool";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Filename;
        private MaterialSkin.Controls.MaterialFlatButton CreateButton;
        private MaterialSkin.Controls.MaterialFlatButton CloseButton;
        private System.Windows.Forms.Label StatusText;
        public System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayShow;
        private System.Windows.Forms.ToolStripMenuItem TrayExit;
        private MaterialSkin.Controls.MaterialFlatButton SyntaxButton;
        public System.Windows.Forms.ToolTip HelpToolTip;
    }
}

