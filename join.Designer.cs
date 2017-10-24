namespace _4team_project
{
    partial class join
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_submit = new System.Windows.Forms.Button();
            this.T_name = new System.Windows.Forms.TextBox();
            this.T_id = new System.Windows.Forms.TextBox();
            this.T_ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // B_submit
            // 
            this.B_submit.Location = new System.Drawing.Point(201, 203);
            this.B_submit.Name = "B_submit";
            this.B_submit.Size = new System.Drawing.Size(92, 29);
            this.B_submit.TabIndex = 3;
            this.B_submit.Text = "신청하기";
            this.B_submit.UseVisualStyleBackColor = true;
            this.B_submit.Click += new System.EventHandler(this.B_submit_Click);
            // 
            // T_name
            // 
            this.T_name.Location = new System.Drawing.Point(133, 40);
            this.T_name.Name = "T_name";
            this.T_name.Size = new System.Drawing.Size(165, 21);
            this.T_name.TabIndex = 4;
            // 
            // T_id
            // 
            this.T_id.Location = new System.Drawing.Point(133, 91);
            this.T_id.Name = "T_id";
            this.T_id.Size = new System.Drawing.Size(163, 21);
            this.T_id.TabIndex = 5;
            // 
            // T_ip
            // 
            this.T_ip.Location = new System.Drawing.Point(133, 152);
            this.T_ip.Name = "T_ip";
            this.T_ip.Size = new System.Drawing.Size(160, 21);
            this.T_ip.TabIndex = 6;
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4team_project.Properties.Resources.자연자연;
            this.ClientSize = new System.Drawing.Size(349, 247);
            this.Controls.Add(this.T_ip);
            this.Controls.Add(this.T_id);
            this.Controls.Add(this.T_name);
            this.Controls.Add(this.B_submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "join";
            this.Text = "join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_submit;
        private System.Windows.Forms.TextBox T_name;
        private System.Windows.Forms.TextBox T_id;
        private System.Windows.Forms.TextBox T_ip;
    }
}