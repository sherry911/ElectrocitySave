namespace _4team_project
{
    partial class res_turnoff
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
            this.time_turnoff = new System.Windows.Forms.TextBox();
            this.b_timeset = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "시간설정(HH:mm)";
            // 
            // time_turnoff
            // 
            this.time_turnoff.Location = new System.Drawing.Point(83, 57);
            this.time_turnoff.Name = "time_turnoff";
            this.time_turnoff.Size = new System.Drawing.Size(129, 21);
            this.time_turnoff.TabIndex = 6;
            // 
            // b_timeset
            // 
            this.b_timeset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_timeset.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b_timeset.ForeColor = System.Drawing.Color.Green;
            this.b_timeset.Location = new System.Drawing.Point(137, 94);
            this.b_timeset.Name = "b_timeset";
            this.b_timeset.Size = new System.Drawing.Size(75, 32);
            this.b_timeset.TabIndex = 7;
            this.b_timeset.Text = "입력";
            this.b_timeset.UseVisualStyleBackColor = false;
            this.b_timeset.Click += new System.EventHandler(this.b_timeset_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_cancel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b_cancel.ForeColor = System.Drawing.Color.Green;
            this.b_cancel.Location = new System.Drawing.Point(137, 132);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 30);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "취소";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // res_turnoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4team_project.Properties.Resources.자연자연;
            this.ClientSize = new System.Drawing.Size(224, 175);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_timeset);
            this.Controls.Add(this.time_turnoff);
            this.Controls.Add(this.label1);
            this.Name = "res_turnoff";
            this.Text = "res_turnoff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time_turnoff;
        private System.Windows.Forms.Button b_timeset;
        private System.Windows.Forms.Button b_cancel;
    }
}