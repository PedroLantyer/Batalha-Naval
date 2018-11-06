namespace Batalha_Naval
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.checkBoxWinRecord = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxGameSpeed = new System.Windows.Forms.GroupBox();
            this.buttonApplyCustomTime = new System.Windows.Forms.Button();
            this.textBoxGameSpeed = new System.Windows.Forms.TextBox();
            this.radioButtonCustomSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonFastGame = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalGame = new System.Windows.Forms.RadioButton();
            this.radioButtonSlowGame = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBoxGameSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxWinRecord
            // 
            this.checkBoxWinRecord.AutoSize = true;
            this.checkBoxWinRecord.Location = new System.Drawing.Point(12, 12);
            this.checkBoxWinRecord.Name = "checkBoxWinRecord";
            this.checkBoxWinRecord.Size = new System.Drawing.Size(83, 17);
            this.checkBoxWinRecord.TabIndex = 6;
            this.checkBoxWinRecord.Text = "Win Record";
            this.checkBoxWinRecord.UseVisualStyleBackColor = true;
            // 
            // groupBoxGameSpeed
            // 
            this.groupBoxGameSpeed.Controls.Add(this.buttonApplyCustomTime);
            this.groupBoxGameSpeed.Controls.Add(this.textBoxGameSpeed);
            this.groupBoxGameSpeed.Controls.Add(this.radioButtonCustomSpeed);
            this.groupBoxGameSpeed.Controls.Add(this.radioButtonFastGame);
            this.groupBoxGameSpeed.Controls.Add(this.radioButtonNormalGame);
            this.groupBoxGameSpeed.Controls.Add(this.radioButtonSlowGame);
            this.groupBoxGameSpeed.Location = new System.Drawing.Point(12, 35);
            this.groupBoxGameSpeed.Name = "groupBoxGameSpeed";
            this.groupBoxGameSpeed.Size = new System.Drawing.Size(200, 121);
            this.groupBoxGameSpeed.TabIndex = 7;
            this.groupBoxGameSpeed.TabStop = false;
            this.groupBoxGameSpeed.Text = "Velocidade:";
            this.groupBoxGameSpeed.EnabledChanged += new System.EventHandler(this.groupBoxGameSpeed_EnabledChanged);
            // 
            // buttonApplyCustomTime
            // 
            this.buttonApplyCustomTime.Location = new System.Drawing.Point(124, 88);
            this.buttonApplyCustomTime.Name = "buttonApplyCustomTime";
            this.buttonApplyCustomTime.Size = new System.Drawing.Size(36, 20);
            this.buttonApplyCustomTime.TabIndex = 5;
            this.buttonApplyCustomTime.Text = "OK";
            this.buttonApplyCustomTime.UseVisualStyleBackColor = true;
            this.buttonApplyCustomTime.Click += new System.EventHandler(this.buttonApplyCustomTime_Click);
            // 
            // textBoxGameSpeed
            // 
            this.textBoxGameSpeed.Location = new System.Drawing.Point(74, 88);
            this.textBoxGameSpeed.Name = "textBoxGameSpeed";
            this.textBoxGameSpeed.ReadOnly = true;
            this.textBoxGameSpeed.Size = new System.Drawing.Size(44, 20);
            this.textBoxGameSpeed.TabIndex = 4;
            this.textBoxGameSpeed.Text = "00:00";
            this.textBoxGameSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonCustomSpeed
            // 
            this.radioButtonCustomSpeed.AutoSize = true;
            this.radioButtonCustomSpeed.Location = new System.Drawing.Point(5, 88);
            this.radioButtonCustomSpeed.Name = "radioButtonCustomSpeed";
            this.radioButtonCustomSpeed.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustomSpeed.TabIndex = 3;
            this.radioButtonCustomSpeed.Text = "Custom:";
            this.radioButtonCustomSpeed.UseVisualStyleBackColor = true;
            this.radioButtonCustomSpeed.Click += new System.EventHandler(this.radioButtonCustomSpeed_Click);
            // 
            // radioButtonFastGame
            // 
            this.radioButtonFastGame.AutoSize = true;
            this.radioButtonFastGame.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFastGame.Name = "radioButtonFastGame";
            this.radioButtonFastGame.Size = new System.Drawing.Size(81, 17);
            this.radioButtonFastGame.TabIndex = 2;
            this.radioButtonFastGame.Text = "Fast (00:30)";
            this.radioButtonFastGame.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormalGame
            // 
            this.radioButtonNormalGame.AutoSize = true;
            this.radioButtonNormalGame.Checked = true;
            this.radioButtonNormalGame.Location = new System.Drawing.Point(6, 42);
            this.radioButtonNormalGame.Name = "radioButtonNormalGame";
            this.radioButtonNormalGame.Size = new System.Drawing.Size(94, 17);
            this.radioButtonNormalGame.TabIndex = 1;
            this.radioButtonNormalGame.TabStop = true;
            this.radioButtonNormalGame.Text = "Normal (01:00)";
            this.radioButtonNormalGame.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlowGame
            // 
            this.radioButtonSlowGame.AutoSize = true;
            this.radioButtonSlowGame.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSlowGame.Name = "radioButtonSlowGame";
            this.radioButtonSlowGame.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSlowGame.TabIndex = 0;
            this.radioButtonSlowGame.Text = "Slow (01:30)";
            this.radioButtonSlowGame.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 168);
            this.Controls.Add(this.groupBoxGameSpeed);
            this.Controls.Add(this.checkBoxWinRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBoxGameSpeed.ResumeLayout(false);
            this.groupBoxGameSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox checkBoxWinRecord;
        public System.Windows.Forms.TextBox textBoxGameSpeed;
        public System.Windows.Forms.RadioButton radioButtonCustomSpeed;
        public System.Windows.Forms.RadioButton radioButtonFastGame;
        public System.Windows.Forms.RadioButton radioButtonNormalGame;
        public System.Windows.Forms.RadioButton radioButtonSlowGame;
        public System.Windows.Forms.GroupBox groupBoxGameSpeed;
        private System.Windows.Forms.Button buttonApplyCustomTime;
    }
}