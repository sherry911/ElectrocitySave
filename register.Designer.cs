namespace _4team_project
{
    partial class register
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
            this.input_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.register_id = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(108, 12);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(139, 21);
            this.input_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(108, 50);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(139, 21);
            this.input_name.TabIndex = 3;
            // 
            // register_id
            // 
            this.register_id.Location = new System.Drawing.Point(108, 122);
            this.register_id.Name = "register_id";
            this.register_id.Size = new System.Drawing.Size(75, 23);
            this.register_id.TabIndex = 4;
            this.register_id.Text = "등록";
            this.register_id.UseVisualStyleBackColor = true;
            this.register_id.Click += new System.EventHandler(this.register_id_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "이메일";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(108, 82);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(139, 21);
            this.input_email.TabIndex = 6;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(189, 122);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 7;
            this.b_cancel.Text = "취소";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_id);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_id);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_id;
        public System.Windows.Forms.TextBox input_id;
        public System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Button b_cancel;
    }
}