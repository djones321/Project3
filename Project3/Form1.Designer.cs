namespace Project3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxFileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxDatesList = new System.Windows.Forms.ListBox();
            this.uxFilterBox = new System.Windows.Forms.GroupBox();
            this.uxThisDate = new System.Windows.Forms.RadioButton();
            this.uxAboveTemp = new System.Windows.Forms.RadioButton();
            this.uxBelowTemp = new System.Windows.Forms.RadioButton();
            this.uxDateRange = new System.Windows.Forms.RadioButton();
            this.uxFilterButton = new System.Windows.Forms.Button();
            this.uxUndoButton = new System.Windows.Forms.Button();
            this.uxCalendar = new System.Windows.Forms.MonthCalendar();
            this.uxTemperatureLabel = new System.Windows.Forms.Label();
            this.uxTempSetting = new System.Windows.Forms.NumericUpDown();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.uxFilterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTempSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxFileTab
            // 
            this.uxFileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenMenu});
            this.uxFileTab.Name = "uxFileTab";
            this.uxFileTab.Size = new System.Drawing.Size(37, 20);
            this.uxFileTab.Text = "File";
            // 
            // uxOpenMenu
            // 
            this.uxOpenMenu.Name = "uxOpenMenu";
            this.uxOpenMenu.Size = new System.Drawing.Size(112, 22);
            this.uxOpenMenu.Text = "Open...";
            this.uxOpenMenu.Click += new System.EventHandler(this.uxOpenMenu_Click);
            // 
            // uxDatesList
            // 
            this.uxDatesList.FormattingEnabled = true;
            this.uxDatesList.Location = new System.Drawing.Point(13, 28);
            this.uxDatesList.Name = "uxDatesList";
            this.uxDatesList.Size = new System.Drawing.Size(362, 264);
            this.uxDatesList.TabIndex = 1;
            // 
            // uxFilterBox
            // 
            this.uxFilterBox.Controls.Add(this.uxThisDate);
            this.uxFilterBox.Controls.Add(this.uxAboveTemp);
            this.uxFilterBox.Controls.Add(this.uxBelowTemp);
            this.uxFilterBox.Controls.Add(this.uxDateRange);
            this.uxFilterBox.Location = new System.Drawing.Point(381, 59);
            this.uxFilterBox.Name = "uxFilterBox";
            this.uxFilterBox.Size = new System.Drawing.Size(245, 170);
            this.uxFilterBox.TabIndex = 2;
            this.uxFilterBox.TabStop = false;
            this.uxFilterBox.Text = "Filter Options";
            // 
            // uxThisDate
            // 
            this.uxThisDate.AutoSize = true;
            this.uxThisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxThisDate.Location = new System.Drawing.Point(7, 125);
            this.uxThisDate.Name = "uxThisDate";
            this.uxThisDate.Size = new System.Drawing.Size(146, 21);
            this.uxThisDate.TabIndex = 3;
            this.uxThisDate.TabStop = true;
            this.uxThisDate.Text = "This date in history";
            this.uxThisDate.UseVisualStyleBackColor = true;
            // 
            // uxAboveTemp
            // 
            this.uxAboveTemp.AutoSize = true;
            this.uxAboveTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxAboveTemp.Location = new System.Drawing.Point(7, 90);
            this.uxAboveTemp.Name = "uxAboveTemp";
            this.uxAboveTemp.Size = new System.Drawing.Size(225, 21);
            this.uxAboveTemp.TabIndex = 2;
            this.uxAboveTemp.TabStop = true;
            this.uxAboveTemp.Text = "Dates above given temperature";
            this.uxAboveTemp.UseVisualStyleBackColor = true;
            // 
            // uxBelowTemp
            // 
            this.uxBelowTemp.AutoSize = true;
            this.uxBelowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxBelowTemp.Location = new System.Drawing.Point(7, 55);
            this.uxBelowTemp.Name = "uxBelowTemp";
            this.uxBelowTemp.Size = new System.Drawing.Size(222, 21);
            this.uxBelowTemp.TabIndex = 1;
            this.uxBelowTemp.TabStop = true;
            this.uxBelowTemp.Text = "Dates below given temperature";
            this.uxBelowTemp.UseVisualStyleBackColor = true;
            // 
            // uxDateRange
            // 
            this.uxDateRange.AutoSize = true;
            this.uxDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxDateRange.Location = new System.Drawing.Point(7, 20);
            this.uxDateRange.Name = "uxDateRange";
            this.uxDateRange.Size = new System.Drawing.Size(205, 21);
            this.uxDateRange.TabIndex = 0;
            this.uxDateRange.TabStop = true;
            this.uxDateRange.Text = "Dates during selected range";
            this.uxDateRange.UseVisualStyleBackColor = true;
            // 
            // uxFilterButton
            // 
            this.uxFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxFilterButton.Location = new System.Drawing.Point(388, 245);
            this.uxFilterButton.Name = "uxFilterButton";
            this.uxFilterButton.Size = new System.Drawing.Size(102, 34);
            this.uxFilterButton.TabIndex = 3;
            this.uxFilterButton.Text = "Filter";
            this.uxFilterButton.UseVisualStyleBackColor = true;
            this.uxFilterButton.Click += new System.EventHandler(this.uxFilterButton_Click);
            // 
            // uxUndoButton
            // 
            this.uxUndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxUndoButton.Location = new System.Drawing.Point(511, 245);
            this.uxUndoButton.Name = "uxUndoButton";
            this.uxUndoButton.Size = new System.Drawing.Size(102, 34);
            this.uxUndoButton.TabIndex = 4;
            this.uxUndoButton.Text = "Undo";
            this.uxUndoButton.UseVisualStyleBackColor = true;
            this.uxUndoButton.Click += new System.EventHandler(this.uxUndoButton_Click);
            // 
            // uxCalendar
            // 
            this.uxCalendar.Location = new System.Drawing.Point(638, 67);
            this.uxCalendar.MaxDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.uxCalendar.MaxSelectionCount = 31;
            this.uxCalendar.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.uxCalendar.Name = "uxCalendar";
            this.uxCalendar.TabIndex = 5;
            // 
            // uxTemperatureLabel
            // 
            this.uxTemperatureLabel.AutoSize = true;
            this.uxTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTemperatureLabel.Location = new System.Drawing.Point(638, 242);
            this.uxTemperatureLabel.Name = "uxTemperatureLabel";
            this.uxTemperatureLabel.Size = new System.Drawing.Size(90, 17);
            this.uxTemperatureLabel.TabIndex = 6;
            this.uxTemperatureLabel.Text = "Temperature";
            // 
            // uxTempSetting
            // 
            this.uxTempSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTempSetting.Location = new System.Drawing.Point(641, 263);
            this.uxTempSetting.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.uxTempSetting.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.uxTempSetting.Name = "uxTempSetting";
            this.uxTempSetting.Size = new System.Drawing.Size(224, 23);
            this.uxTempSetting.TabIndex = 7;
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            this.uxOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 330);
            this.Controls.Add(this.uxTempSetting);
            this.Controls.Add(this.uxTemperatureLabel);
            this.Controls.Add(this.uxCalendar);
            this.Controls.Add(this.uxUndoButton);
            this.Controls.Add(this.uxFilterButton);
            this.Controls.Add(this.uxFilterBox);
            this.Controls.Add(this.uxDatesList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uxFilterBox.ResumeLayout(false);
            this.uxFilterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTempSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxFileTab;
        private System.Windows.Forms.ToolStripMenuItem uxOpenMenu;
        private System.Windows.Forms.ListBox uxDatesList;
        private System.Windows.Forms.GroupBox uxFilterBox;
        private System.Windows.Forms.RadioButton uxThisDate;
        private System.Windows.Forms.RadioButton uxAboveTemp;
        private System.Windows.Forms.RadioButton uxBelowTemp;
        private System.Windows.Forms.RadioButton uxDateRange;
        private System.Windows.Forms.Button uxFilterButton;
        private System.Windows.Forms.Button uxUndoButton;
        private System.Windows.Forms.MonthCalendar uxCalendar;
        private System.Windows.Forms.Label uxTemperatureLabel;
        private System.Windows.Forms.NumericUpDown uxTempSetting;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
    }
}

