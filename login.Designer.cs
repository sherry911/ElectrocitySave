namespace _4team_project
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_login = new System.Windows.Forms.Button();
            this.B_join = new System.Windows.Forms.Button();
            this.T_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_login
            // 
            this.B_login.Location = new System.Drawing.Point(231, 66);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(68, 38);
            this.B_login.TabIndex = 0;
            this.B_login.Text = "로그인";
            this.B_login.UseVisualStyleBackColor = true;
            this.B_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // B_join
            // 
            this.B_join.Location = new System.Drawing.Point(311, 66);
            this.B_join.Name = "B_join";
            this.B_join.Size = new System.Drawing.Size(62, 37);
            this.B_join.TabIndex = 1;
            this.B_join.Text = "회원가입";
            this.B_join.UseVisualStyleBackColor = true;
            this.B_join.Click += new System.EventHandler(this.B_join_Click);
            // 
            // T_ID
            // 
            this.T_ID.Location = new System.Drawing.Point(32, 73);
            this.T_ID.Name = "T_ID";
            this.T_ID.Size = new System.Drawing.Size(179, 21);
            this.T_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4team_project.Properties.Resources.자연자연;
            this.ClientSize = new System.Drawing.Size(404, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_ID);
            this.Controls.Add(this.B_join);
            this.Controls.Add(this.B_login);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_login;
        private System.Windows.Forms.Button B_join;
        private System.Windows.Forms.TextBox T_ID;
        private System.Windows.Forms.Label label1;
    }
}

