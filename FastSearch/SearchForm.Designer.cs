namespace FastSearch
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.FSnotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aplikacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBtext = new System.Windows.Forms.TextBox();
            this.BApp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bconf = new System.Windows.Forms.Button();
            this.Balfa = new System.Windows.Forms.Button();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FSnotify
            // 
            this.FSnotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.FSnotify.ContextMenuStrip = this.NotifyMenu;
            this.FSnotify.Icon = ((System.Drawing.Icon)(resources.GetObject("FSnotify.Icon")));
            this.FSnotify.Text = "Fast Search";
            this.FSnotify.Visible = true;
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjeToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(132, 76);
            // 
            // aplikacjeToolStripMenuItem
            // 
            this.aplikacjeToolStripMenuItem.Name = "aplikacjeToolStripMenuItem";
            this.aplikacjeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aplikacjeToolStripMenuItem.Text = "Aplikacje";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // TBtext
            // 
            this.TBtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBtext.Location = new System.Drawing.Point(0, 0);
            this.TBtext.Name = "TBtext";
            this.TBtext.Size = new System.Drawing.Size(255, 20);
            this.TBtext.TabIndex = 1;
            this.TBtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBtext_KeyDown);
            // 
            // BApp
            // 
            this.BApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BApp.Location = new System.Drawing.Point(0, 23);
            this.BApp.Margin = new System.Windows.Forms.Padding(0);
            this.BApp.Name = "BApp";
            this.BApp.Size = new System.Drawing.Size(64, 22);
            this.BApp.TabIndex = 2;
            this.BApp.Text = "Aplikacje";
            this.BApp.UseVisualStyleBackColor = true;
            this.BApp.Click += new System.EventHandler(this.BApp_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(63, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Bconf
            // 
            this.Bconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bconf.Location = new System.Drawing.Point(137, 23);
            this.Bconf.Margin = new System.Windows.Forms.Padding(0);
            this.Bconf.Name = "Bconf";
            this.Bconf.Size = new System.Drawing.Size(75, 22);
            this.Bconf.TabIndex = 4;
            this.Bconf.Text = "Konfiguracja";
            this.Bconf.UseVisualStyleBackColor = true;
            this.Bconf.Click += new System.EventHandler(this.Bconf_Click);
            // 
            // Balfa
            // 
            this.Balfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Balfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Balfa.Location = new System.Drawing.Point(211, 23);
            this.Balfa.Margin = new System.Windows.Forms.Padding(0);
            this.Balfa.Name = "Balfa";
            this.Balfa.Size = new System.Drawing.Size(35, 22);
            this.Balfa.TabIndex = 5;
            this.Balfa.Text = "Alfa";
            this.Balfa.UseVisualStyleBackColor = true;
            this.Balfa.Click += new System.EventHandler(this.Balfa_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(255, 42);
            this.ControlBox = false;
            this.Controls.Add(this.Balfa);
            this.Controls.Add(this.Bconf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BApp);
            this.Controls.Add(this.TBtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon FSnotify;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem aplikacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.TextBox TBtext;
        private System.Windows.Forms.Button BApp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Bconf;
        private System.Windows.Forms.Button Balfa;
    }
}

