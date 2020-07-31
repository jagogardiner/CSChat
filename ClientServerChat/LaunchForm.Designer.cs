namespace ClientServerChat
{
    partial class LaunchForm
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
            this.launchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchComboBox
            // 
            this.launchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.launchComboBox.FormattingEnabled = true;
            this.launchComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.launchComboBox.Location = new System.Drawing.Point(78, 6);
            this.launchComboBox.Name = "launchComboBox";
            this.launchComboBox.Size = new System.Drawing.Size(82, 21);
            this.launchComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Launch as:";
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(85, 39);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(172, 74);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaunchForm";
            this.Text = "CSChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox launchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button launchButton;
    }
}

