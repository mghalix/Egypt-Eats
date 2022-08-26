namespace Egypt_Eats
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDesk = new System.Windows.Forms.Panel();
            this.darkToggle = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.Transparent;
            this.panelOptions.Controls.Add(this.btnSettings);
            this.panelOptions.Controls.Add(this.btnOrders);
            this.panelOptions.Controls.Add(this.btnDeals);
            this.panelOptions.Controls.Add(this.btnHome);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 804);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1052, 53);
            this.panelOptions.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.darkToggle);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 52);
            this.panel2.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(497, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDesk
            // 
            this.pnlDesk.AutoSize = true;
            this.pnlDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesk.Font = new System.Drawing.Font("Nirmala UI", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDesk.Location = new System.Drawing.Point(0, 52);
            this.pnlDesk.Name = "pnlDesk";
            this.pnlDesk.Size = new System.Drawing.Size(1052, 752);
            this.pnlDesk.TabIndex = 1;
            // 
            // darkToggle
            // 
            this.darkToggle.BackColor = System.Drawing.Color.Transparent;
            this.darkToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.darkToggle.Cursor = System.Windows.Forms.Cursors.Default;
            this.darkToggle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.darkToggle.FlatAppearance.BorderSize = 0;
            this.darkToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.darkToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.darkToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkToggle.ForeColor = System.Drawing.Color.White;
            this.darkToggle.Image = global::Egypt_Eats.Properties.Resources.Nightmode;
            this.darkToggle.Location = new System.Drawing.Point(1007, 7);
            this.darkToggle.Name = "darkToggle";
            this.darkToggle.Size = new System.Drawing.Size(36, 29);
            this.darkToggle.TabIndex = 35;
            this.darkToggle.UseVisualStyleBackColor = false;
            this.darkToggle.Click += new System.EventHandler(this.darkToggle_Click);
            this.darkToggle.MouseEnter += new System.EventHandler(this.darkToggle_MouseEnter);
            this.darkToggle.MouseLeave += new System.EventHandler(this.darkToggle_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Image = global::Egypt_Eats.Properties.Resources.titlebutton_maximize;
            this.btnMaximize.Location = new System.Drawing.Point(45, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 21);
            this.btnMaximize.TabIndex = 34;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.btnMaximize_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Egypt_Eats.Properties.Resources.titlebutton_minimize;
            this.btnMinimize.Location = new System.Drawing.Point(23, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 21);
            this.btnMinimize.TabIndex = 33;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Egypt_Eats.Properties.Resources.titlebutton_close;
            this.btnClose.Location = new System.Drawing.Point(3, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 21);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.86792F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::Egypt_Eats.Properties.Resources.btnSettings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(789, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(263, 53);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "              Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Nirmala UI", 10.86792F, System.Drawing.FontStyle.Bold);
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Image = global::Egypt_Eats.Properties.Resources.btnOrders;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(526, 0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(263, 53);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "               Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeals.BackColor = System.Drawing.Color.Transparent;
            this.btnDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeals.FlatAppearance.BorderSize = 0;
            this.btnDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeals.Font = new System.Drawing.Font("Nirmala UI", 10.86792F, System.Drawing.FontStyle.Bold);
            this.btnDeals.ForeColor = System.Drawing.Color.Black;
            this.btnDeals.Image = global::Egypt_Eats.Properties.Resources.btnDeals;
            this.btnDeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeals.Location = new System.Drawing.Point(263, 0);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(263, 53);
            this.btnDeals.TabIndex = 1;
            this.btnDeals.Text = "                Deals";
            this.btnDeals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeals.UseVisualStyleBackColor = false;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::Egypt_Eats.Properties.Resources.btnHome;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(263, 53);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "               Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 857);
            this.Controls.Add(this.pnlDesk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1052, 857);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egypt Eats";
            this.Load += new System.EventHandler(this.frmMainUpgraded_Load);
            this.panelOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDesk;
        private System.Windows.Forms.Button darkToggle;
    }
}