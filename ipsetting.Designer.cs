namespace _4team_project
{
    partial class ipsetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.B_modify = new System.Windows.Forms.Button();
            this.T_ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // B_modify
            // 
            this.B_modify.Location = new System.Drawing.Point(150, 82);
            this.B_modify.Name = "B_modify";
            this.B_modify.Size = new System.Drawing.Size(75, 23);
            this.B_modify.TabIndex = 1;
            this.B_modify.Text = "수정하기";
            this.B_modify.UseVisualStyleBackColor = true;
            // 
            // T_ip
            // 
            this.T_ip.Location = new System.Drawing.Point(41, 34);
            this.T_ip.Name = "T_ip";
            this.T_ip.Size = new System.Drawing.Size(184, 21);
            this.T_ip.TabIndex = 2;
            // 
            // ipsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 130);
            this.Controls.Add(this.T_ip);
            this.Controls.Add(this.B_modify);
            this.Controls.Add(this.label1);
            this.Name = "ipsetting";
            this.Text = "ipsetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_modify;
        private System.Windows.Forms.TextBox T_ip;
    }
}