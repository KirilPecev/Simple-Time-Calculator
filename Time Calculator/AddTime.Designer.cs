namespace Time_Calculator
{
    partial class AddTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTime));
            this.enterTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTimeTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTimeTextBox
            // 
            this.enterTimeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.enterTimeTextBox.Location = new System.Drawing.Point(279, 64);
            this.enterTimeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.enterTimeTextBox.Name = "enterTimeTextBox";
            this.enterTimeTextBox.Size = new System.Drawing.Size(114, 24);
            this.enterTimeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter time, which I must add:";
            // 
            // addTimeTextBox
            // 
            this.addTimeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.addTimeTextBox.Location = new System.Drawing.Point(279, 111);
            this.addTimeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addTimeTextBox.Name = "addTimeTextBox";
            this.addTimeTextBox.Size = new System.Drawing.Size(114, 24);
            this.addTimeTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calculateButton.Location = new System.Drawing.Point(27, 162);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(367, 32);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(25, 28);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(367, 29);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "Click here if you want to subtract time.";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // AddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 222);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.addTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterTimeTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddTime";
            this.Text = "Time Calculator - Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addTimeTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button subtractButton;
    }
}

