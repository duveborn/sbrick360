namespace FlowersFX.SBrick360.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.sbricksListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motor0PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.motor1PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.motor2PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.motor3PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.motor0Value = new System.Windows.Forms.Label();
            this.motor1Value = new System.Windows.Forms.Label();
            this.motor2Value = new System.Windows.Forms.Label();
            this.motor3Value = new System.Windows.Forms.Label();
            this.motorControlsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamepadDropDownBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.motor0PowerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor1PowerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor2PowerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor3PowerTrackBar)).BeginInit();
            this.motorControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbricksListView
            // 
            this.sbricksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.sbricksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbricksListView.FullRowSelect = true;
            this.sbricksListView.HideSelection = false;
            this.sbricksListView.Location = new System.Drawing.Point(0, 0);
            this.sbricksListView.MultiSelect = false;
            this.sbricksListView.Name = "sbricksListView";
            this.sbricksListView.Size = new System.Drawing.Size(131, 510);
            this.sbricksListView.TabIndex = 0;
            this.sbricksListView.UseCompatibleStateImageBehavior = false;
            this.sbricksListView.View = System.Windows.Forms.View.Details;
            this.sbricksListView.SelectedIndexChanged += new System.EventHandler(this.sbricksListView_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Paired SBricks";
            this.name.Width = 112;
            // 
            // motor0PowerTrackBar
            // 
            this.motor0PowerTrackBar.LargeChange = 32;
            this.motor0PowerTrackBar.Location = new System.Drawing.Point(233, 104);
            this.motor0PowerTrackBar.Maximum = 255;
            this.motor0PowerTrackBar.Minimum = -255;
            this.motor0PowerTrackBar.Name = "motor0PowerTrackBar";
            this.motor0PowerTrackBar.Size = new System.Drawing.Size(220, 45);
            this.motor0PowerTrackBar.SmallChange = 16;
            this.motor0PowerTrackBar.TabIndex = 3;
            this.motor0PowerTrackBar.TickFrequency = 16;
            // 
            // motor1PowerTrackBar
            // 
            this.motor1PowerTrackBar.LargeChange = 32;
            this.motor1PowerTrackBar.Location = new System.Drawing.Point(9, 237);
            this.motor1PowerTrackBar.Maximum = 255;
            this.motor1PowerTrackBar.Minimum = -255;
            this.motor1PowerTrackBar.Name = "motor1PowerTrackBar";
            this.motor1PowerTrackBar.Size = new System.Drawing.Size(204, 45);
            this.motor1PowerTrackBar.SmallChange = 16;
            this.motor1PowerTrackBar.TabIndex = 4;
            this.motor1PowerTrackBar.TickFrequency = 16;
            // 
            // motor2PowerTrackBar
            // 
            this.motor2PowerTrackBar.LargeChange = 32;
            this.motor2PowerTrackBar.Location = new System.Drawing.Point(459, 237);
            this.motor2PowerTrackBar.Maximum = 255;
            this.motor2PowerTrackBar.Minimum = -255;
            this.motor2PowerTrackBar.Name = "motor2PowerTrackBar";
            this.motor2PowerTrackBar.Size = new System.Drawing.Size(204, 45);
            this.motor2PowerTrackBar.SmallChange = 16;
            this.motor2PowerTrackBar.TabIndex = 5;
            this.motor2PowerTrackBar.TickFrequency = 16;
            // 
            // motor3PowerTrackBar
            // 
            this.motor3PowerTrackBar.LargeChange = 32;
            this.motor3PowerTrackBar.Location = new System.Drawing.Point(233, 392);
            this.motor3PowerTrackBar.Maximum = 255;
            this.motor3PowerTrackBar.Minimum = -255;
            this.motor3PowerTrackBar.Name = "motor3PowerTrackBar";
            this.motor3PowerTrackBar.Size = new System.Drawing.Size(208, 45);
            this.motor3PowerTrackBar.SmallChange = 16;
            this.motor3PowerTrackBar.TabIndex = 6;
            this.motor3PowerTrackBar.TickFrequency = 16;
            // 
            // motor0Value
            // 
            this.motor0Value.AutoSize = true;
            this.motor0Value.Location = new System.Drawing.Point(340, 88);
            this.motor0Value.Name = "motor0Value";
            this.motor0Value.Size = new System.Drawing.Size(13, 13);
            this.motor0Value.TabIndex = 11;
            this.motor0Value.Text = "0";
            // 
            // motor1Value
            // 
            this.motor1Value.AutoSize = true;
            this.motor1Value.Location = new System.Drawing.Point(106, 221);
            this.motor1Value.Name = "motor1Value";
            this.motor1Value.Size = new System.Drawing.Size(13, 13);
            this.motor1Value.TabIndex = 12;
            this.motor1Value.Text = "0";
            // 
            // motor2Value
            // 
            this.motor2Value.AutoSize = true;
            this.motor2Value.Location = new System.Drawing.Point(556, 221);
            this.motor2Value.Name = "motor2Value";
            this.motor2Value.Size = new System.Drawing.Size(13, 13);
            this.motor2Value.TabIndex = 13;
            this.motor2Value.Text = "0";
            // 
            // motor3Value
            // 
            this.motor3Value.AutoSize = true;
            this.motor3Value.Location = new System.Drawing.Point(332, 376);
            this.motor3Value.Name = "motor3Value";
            this.motor3Value.Size = new System.Drawing.Size(13, 13);
            this.motor3Value.TabIndex = 14;
            this.motor3Value.Text = "0";
            // 
            // motorControlsPanel
            // 
            this.motorControlsPanel.Controls.Add(this.label2);
            this.motorControlsPanel.Controls.Add(this.pictureBox6);
            this.motorControlsPanel.Controls.Add(this.pictureBox5);
            this.motorControlsPanel.Controls.Add(this.pictureBox4);
            this.motorControlsPanel.Controls.Add(this.pictureBox3);
            this.motorControlsPanel.Controls.Add(this.pictureBox2);
            this.motorControlsPanel.Controls.Add(this.pictureBox1);
            this.motorControlsPanel.Controls.Add(this.gamepadDropDownBox);
            this.motorControlsPanel.Controls.Add(this.label1);
            this.motorControlsPanel.Controls.Add(this.motor0PowerTrackBar);
            this.motorControlsPanel.Controls.Add(this.motor3Value);
            this.motorControlsPanel.Controls.Add(this.motor1PowerTrackBar);
            this.motorControlsPanel.Controls.Add(this.motor2Value);
            this.motorControlsPanel.Controls.Add(this.motor2PowerTrackBar);
            this.motorControlsPanel.Controls.Add(this.motor1Value);
            this.motorControlsPanel.Controls.Add(this.motor3PowerTrackBar);
            this.motorControlsPanel.Controls.Add(this.motor0Value);
            this.motorControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.motorControlsPanel.Name = "motorControlsPanel";
            this.motorControlsPanel.Size = new System.Drawing.Size(682, 510);
            this.motorControlsPanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "or";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(356, 423);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(97, 78);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(511, 142);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(292, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(233, 429);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(58, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // gamepadDropDownBox
            // 
            this.gamepadDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamepadDropDownBox.Enabled = false;
            this.gamepadDropDownBox.FormattingEnabled = true;
            this.gamepadDropDownBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4"});
            this.gamepadDropDownBox.Location = new System.Drawing.Point(108, 9);
            this.gamepadDropDownBox.Name = "gamepadDropDownBox";
            this.gamepadDropDownBox.Size = new System.Drawing.Size(61, 21);
            this.gamepadDropDownBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Assigned Gamepad:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(7, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sbricksListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.motorControlsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(817, 510);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusMessageLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusMessageLabel
            // 
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 559);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 472);
            this.Name = "MainWindow";
            this.Text = "SBrick360 - FlowersFX";
            ((System.ComponentModel.ISupportInitialize)(this.motor0PowerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor1PowerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor2PowerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor3PowerTrackBar)).EndInit();
            this.motorControlsPanel.ResumeLayout(false);
            this.motorControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sbricksListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.TrackBar motor0PowerTrackBar;
        private System.Windows.Forms.TrackBar motor1PowerTrackBar;
        private System.Windows.Forms.TrackBar motor2PowerTrackBar;
        private System.Windows.Forms.TrackBar motor3PowerTrackBar;
        private System.Windows.Forms.Label motor0Value;
        private System.Windows.Forms.Label motor1Value;
        private System.Windows.Forms.Label motor2Value;
        private System.Windows.Forms.Label motor3Value;
        private System.Windows.Forms.Panel motorControlsPanel;
        private System.Windows.Forms.ComboBox gamepadDropDownBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessageLabel;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

