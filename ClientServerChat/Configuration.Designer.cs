namespace ClientServerChat
{
    partial class Configuration
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
            this.SetConfigButton = new System.Windows.Forms.Button();
            this.AddressConfigBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerPortConfigLabel = new System.Windows.Forms.Label();
            this.PortConfig = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DelayConfig = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // SetConfigButton
            // 
            this.SetConfigButton.Location = new System.Drawing.Point(126, 97);
            this.SetConfigButton.Name = "SetConfigButton";
            this.SetConfigButton.Size = new System.Drawing.Size(75, 23);
            this.SetConfigButton.TabIndex = 0;
            this.SetConfigButton.Text = "Set";
            this.SetConfigButton.UseVisualStyleBackColor = true;
            this.SetConfigButton.Click += new System.EventHandler(this.SetConfigButton_Click);
            // 
            // AddressConfigBox
            // 
            this.AddressConfigBox.Location = new System.Drawing.Point(63, 12);
            this.AddressConfigBox.Name = "AddressConfigBox";
            this.AddressConfigBox.Size = new System.Drawing.Size(138, 20);
            this.AddressConfigBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // ServerPortConfigLabel
            // 
            this.ServerPortConfigLabel.AutoSize = true;
            this.ServerPortConfigLabel.Location = new System.Drawing.Point(12, 40);
            this.ServerPortConfigLabel.Name = "ServerPortConfigLabel";
            this.ServerPortConfigLabel.Size = new System.Drawing.Size(60, 13);
            this.ServerPortConfigLabel.TabIndex = 3;
            this.ServerPortConfigLabel.Text = "Server Port";
            // 
            // PortConfig
            // 
            this.PortConfig.Location = new System.Drawing.Point(138, 38);
            this.PortConfig.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortConfig.Name = "PortConfig";
            this.PortConfig.Size = new System.Drawing.Size(63, 20);
            this.PortConfig.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User message delay";
            // 
            // DelayConfig
            // 
            this.DelayConfig.Location = new System.Drawing.Point(138, 64);
            this.DelayConfig.Name = "DelayConfig";
            this.DelayConfig.Size = new System.Drawing.Size(63, 20);
            this.DelayConfig.TabIndex = 6;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 132);
            this.Controls.Add(this.DelayConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortConfig);
            this.Controls.Add(this.ServerPortConfigLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressConfigBox);
            this.Controls.Add(this.SetConfigButton);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetConfigButton;
        private System.Windows.Forms.TextBox AddressConfigBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServerPortConfigLabel;
        private System.Windows.Forms.NumericUpDown PortConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DelayConfig;
    }
}