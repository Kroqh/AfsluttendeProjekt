namespace PM_GUI_Client
{
    partial class PMGUI
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
            this.champList = new System.Windows.Forms.ListView();
            this._Name = new System.Windows.Forms.ColumnHeader();
            this.Pickrate = new System.Windows.Forms.ColumnHeader();
            this.Winrate = new System.Windows.Forms.ColumnHeader();
            this.Kills = new System.Windows.Forms.ColumnHeader();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.sortKillsBtn = new System.Windows.Forms.Button();
            this.sortWinBtn = new System.Windows.Forms.Button();
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.sortPickBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sortPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // champList
            // 
            this.champList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Name,
            this.Pickrate,
            this.Winrate,
            this.Kills});
            this.champList.FullRowSelect = true;
            this.champList.GridLines = true;
            this.champList.Location = new System.Drawing.Point(247, 11);
            this.champList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.champList.MultiSelect = false;
            this.champList.Name = "champList";
            this.champList.Size = new System.Drawing.Size(397, 432);
            this.champList.TabIndex = 1;
            this.champList.TabStop = false;
            this.champList.UseCompatibleStateImageBehavior = false;
            this.champList.View = System.Windows.Forms.View.Details;
            // 
            // _Name
            // 
            this._Name.Text = "Name";
            this._Name.Width = 150;
            // 
            // Pickrate
            // 
            this.Pickrate.Text = "Pickrate";
            this.Pickrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pickrate.Width = 80;
            // 
            // Winrate
            // 
            this.Winrate.Text = "Winrate";
            this.Winrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Winrate.Width = 80;
            // 
            // Kills
            // 
            this.Kills.Text = "Average kills";
            this.Kills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kills.Width = 80;
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortPanel.Controls.Add(this.sortKillsBtn);
            this.sortPanel.Controls.Add(this.sortWinBtn);
            this.sortPanel.Controls.Add(this.sortNameBtn);
            this.sortPanel.Controls.Add(this.sortPickBtn);
            this.sortPanel.Location = new System.Drawing.Point(6, 94);
            this.sortPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(233, 349);
            this.sortPanel.TabIndex = 9;
            // 
            // sortKillsBtn
            // 
            this.sortKillsBtn.Location = new System.Drawing.Point(14, 180);
            this.sortKillsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortKillsBtn.Name = "sortKillsBtn";
            this.sortKillsBtn.Size = new System.Drawing.Size(204, 51);
            this.sortKillsBtn.TabIndex = 4;
            this.sortKillsBtn.Text = "Sort by average kills";
            this.sortKillsBtn.UseVisualStyleBackColor = true;
            this.sortKillsBtn.Click += new System.EventHandler(this.sortKillsBtn_Click);
            // 
            // sortWinBtn
            // 
            this.sortWinBtn.Location = new System.Drawing.Point(14, 123);
            this.sortWinBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortWinBtn.Name = "sortWinBtn";
            this.sortWinBtn.Size = new System.Drawing.Size(204, 51);
            this.sortWinBtn.TabIndex = 3;
            this.sortWinBtn.Text = "Sort by winrate";
            this.sortWinBtn.UseVisualStyleBackColor = true;
            this.sortWinBtn.Click += new System.EventHandler(this.sortWinBtn_Click);
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.Location = new System.Drawing.Point(14, 9);
            this.sortNameBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(204, 51);
            this.sortNameBtn.TabIndex = 2;
            this.sortNameBtn.Text = "Sort by name";
            this.sortNameBtn.UseVisualStyleBackColor = true;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // sortPickBtn
            // 
            this.sortPickBtn.Location = new System.Drawing.Point(14, 66);
            this.sortPickBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortPickBtn.Name = "sortPickBtn";
            this.sortPickBtn.Size = new System.Drawing.Size(204, 51);
            this.sortPickBtn.TabIndex = 1;
            this.sortPickBtn.Text = "Sort by pickrate";
            this.sortPickBtn.UseVisualStyleBackColor = true;
            this.sortPickBtn.Click += new System.EventHandler(this.sortPickBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshBtn.Location = new System.Drawing.Point(6, 11);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(234, 77);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "REFRESH LIST";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // PMGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 455);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.sortPanel);
            this.Controls.Add(this.champList);
            this.Name = "PMGUI";
            this.Text = "PMGUI";
            this.sortPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView champList;
        private ColumnHeader _Name;
        private ColumnHeader Pickrate;
        private ColumnHeader Winrate;
        private ColumnHeader Kills;
        private Panel sortPanel;
        private Button sortKillsBtn;
        private Button sortWinBtn;
        private Button sortNameBtn;
        private Button sortPickBtn;
        private Button refreshBtn;
    }
}