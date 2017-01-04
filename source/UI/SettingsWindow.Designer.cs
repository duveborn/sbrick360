namespace FlowersFX.SBrick360.UI
{
    partial class SettingsWindow
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
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commandRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commandRateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(92, 91);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(79, 23);
            this.saveSettingsButton.TabIndex = 0;
            this.saveSettingsButton.Text = "OK";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSettingsButton.Location = new System.Drawing.Point(177, 91);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(79, 23);
            this.cancelSettingsButton.TabIndex = 1;
            this.cancelSettingsButton.Text = "Cancel";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update rate:";
            // 
            // commandRateUpDown
            // 
            this.commandRateUpDown.Location = new System.Drawing.Point(85, 11);
            this.commandRateUpDown.Name = "commandRateUpDown";
            this.commandRateUpDown.Size = new System.Drawing.Size(51, 20);
            this.commandRateUpDown.TabIndex = 3;
            this.commandRateUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.commandRateUpDown.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "commands per second";
            // 
            // SettingsWindow
            // 
            this.AcceptButton = this.saveSettingsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelSettingsButton;
            this.ClientSize = new System.Drawing.Size(269, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commandRateUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.saveSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.commandRateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown commandRateUpDown;
        private System.Windows.Forms.Label label2;

    }
}