namespace Time_Calculator
{
    partial class SubtractTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtractTime));
            this.backButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtractTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.Color.Gray;
            this.backButton.Location = new System.Drawing.Point(28, 24);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(376, 29);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Go to Add Form.";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calculateButton.Location = new System.Drawing.Point(28, 165);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(376, 32);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtractTimeTextBox
            // 
            this.subtractTimeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subtractTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.subtractTimeTextBox.Location = new System.Drawing.Point(290, 119);
            this.subtractTimeTextBox.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.subtractTimeTextBox.Name = "subtractTimeTextBox";
            this.subtractTimeTextBox.Size = new System.Drawing.Size(114, 24);
            this.subtractTimeTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter time, which I must subtract:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter time:";
            // 
            // enterTimeTextBox
            // 
            this.enterTimeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.enterTimeTextBox.Location = new System.Drawing.Point(290, 70);
            this.enterTimeTextBox.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.enterTimeTextBox.Name = "enterTimeTextBox";
            this.enterTimeTextBox.Size = new System.Drawing.Size(114, 24);
            this.enterTimeTextBox.TabIndex = 6;
            // 
            // SubtractTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 222);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.subtractTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterTimeTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubtractTime";
            this.Text = "Time Calculator - Subtract Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox subtractTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterTimeTextBox;
    }
}