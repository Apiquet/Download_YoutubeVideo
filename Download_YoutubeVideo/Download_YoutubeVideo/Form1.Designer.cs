namespace Download_YoutubeVideo
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
            this.Download = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(98, 86);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(75, 23);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(44, 54);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address:";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(98, 51);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(335, 20);
            this.textAddress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 162);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Download);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textAddress;
    }
}

