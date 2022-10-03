namespace Chess
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
            this.LocalGameBtn = new System.Windows.Forms.Button();
            this.LocalNetworkBtn = new System.Windows.Forms.Button();
            this.OnlineBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocalGameBtn
            // 
            this.LocalGameBtn.Location = new System.Drawing.Point(361, 105);
            this.LocalGameBtn.Name = "LocalGameBtn";
            this.LocalGameBtn.Size = new System.Drawing.Size(87, 23);
            this.LocalGameBtn.TabIndex = 0;
            this.LocalGameBtn.Text = "Local Game";
            this.LocalGameBtn.UseVisualStyleBackColor = true;
            // 
            // LocalNetworkBtn
            // 
            this.LocalNetworkBtn.Location = new System.Drawing.Point(361, 192);
            this.LocalNetworkBtn.Name = "LocalNetworkBtn";
            this.LocalNetworkBtn.Size = new System.Drawing.Size(87, 23);
            this.LocalNetworkBtn.TabIndex = 1;
            this.LocalNetworkBtn.Text = "Local Network";
            this.LocalNetworkBtn.UseVisualStyleBackColor = true;
            // 
            // OnlineBtn
            // 
            this.OnlineBtn.Location = new System.Drawing.Point(361, 280);
            this.OnlineBtn.Name = "OnlineBtn";
            this.OnlineBtn.Size = new System.Drawing.Size(87, 23);
            this.OnlineBtn.TabIndex = 2;
            this.OnlineBtn.Text = "OnlineGame";
            this.OnlineBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OnlineBtn);
            this.Controls.Add(this.LocalNetworkBtn);
            this.Controls.Add(this.LocalGameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LocalGameBtn;
        private System.Windows.Forms.Button LocalNetworkBtn;
        private System.Windows.Forms.Button OnlineBtn;
    }
}

