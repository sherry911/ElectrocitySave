namespace _4team_project
{
    partial class new_login
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
            this.b_exist = new System.Windows.Forms.Button();
            this.b_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_exist
            // 
            this.b_exist.Location = new System.Drawing.Point(27, 35);
            this.b_exist.Name = "b_exist";
            this.b_exist.Size = new System.Drawing.Size(120, 47);
            this.b_exist.TabIndex = 0;
            this.b_exist.Text = "기존사용자";
            this.b_exist.UseVisualStyleBackColor = true;
            this.b_exist.Click += new System.EventHandler(this.b_exist_Click);
            // 
            // b_new
            // 
            this.b_new.Location = new System.Drawing.Point(153, 35);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(119, 47);
            this.b_new.TabIndex = 1;
            this.b_new.Text = "새 사용자 등록";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // new_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.b_new);
            this.Controls.Add(this.b_exist);
            this.Name = "new_login";
            this.Text = "new_login";
            this.Load += new System.EventHandler(this.new_login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_exist;
        private System.Windows.Forms.Button b_new;
    }
}