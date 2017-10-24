namespace _4team_project
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.L_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripSplitButton();
            this.menu_monitoroff = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_turnoff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_standby = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hinernate = new System.Windows.Forms.ToolStripMenuItem();
            this.로그기록보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.L_ip = new System.Windows.Forms.Label();
            this.L_screen_s = new System.Windows.Forms.Label();
            this.L_standby_s = new System.Windows.Forms.Label();
            this.L_monitoroff_s = new System.Windows.Forms.Label();
            this.t_hibernate = new System.Windows.Forms.Timer(this.components);
            this.t_off = new System.Windows.Forms.Timer(this.components);
            this.t_mo = new System.Windows.Forms.Timer(this.components);
            this.t_ss = new System.Windows.Forms.Timer(this.components);
            this.t_sb = new System.Windows.Forms.Timer(this.components);
            this.mailer = new System.Windows.Forms.Timer(this.components);
            this.mailertime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.time_off = new System.Windows.Forms.Button();
            this.time_hibernate = new System.Windows.Forms.Button();
            this.chk_off = new System.Windows.Forms.CheckBox();
            this.chk_hibernate = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.opt_sb20 = new System.Windows.Forms.RadioButton();
            this.opt_sb10 = new System.Windows.Forms.RadioButton();
            this.opt_sb30 = new System.Windows.Forms.RadioButton();
            this.opt_sb0 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opt_mo30 = new System.Windows.Forms.RadioButton();
            this.opt_mo10 = new System.Windows.Forms.RadioButton();
            this.opt_mo20 = new System.Windows.Forms.RadioButton();
            this.opt_mo0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_ss30 = new System.Windows.Forms.RadioButton();
            this.opt_ss20 = new System.Windows.Forms.RadioButton();
            this.opt_ss10 = new System.Windows.Forms.RadioButton();
            this.opt_ss0 = new System.Windows.Forms.RadioButton();
            this.reservation = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.BackColor = System.Drawing.Color.Transparent;
            this.L_name.Font = new System.Drawing.Font("한컴 윤체 M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.L_name.Location = new System.Drawing.Point(13, 29);
            this.L_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(46, 22);
            this.L_name.TabIndex = 0;
            this.L_name.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("한컴 윤체 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(67, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "님이 로그인 하셨습니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("한컴 윤체 L", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "모니터끄기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "대기모드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("한컴 윤체 L", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(17, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "화면보호기";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "등록된 메일";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.finish});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 29);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_monitoroff,
            this.menu_turnoff,
            this.toolStripSeparator1,
            this.menu_standby,
            this.menu_hinernate,
            this.로그기록보기ToolStripMenuItem});
            this.menu.Font = new System.Drawing.Font("한컴 윤체 B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(62, 22);
            this.menu.Text = "메뉴";
            // 
            // menu_monitoroff
            // 
            this.menu_monitoroff.Image = global::_4team_project.Properties.Resources.monitoroff;
            this.menu_monitoroff.Name = "menu_monitoroff";
            this.menu_monitoroff.Size = new System.Drawing.Size(156, 26);
            this.menu_monitoroff.Text = "모니터 끄기";
            this.menu_monitoroff.Click += new System.EventHandler(this.menu_monitoroff_Click);
            // 
            // menu_turnoff
            // 
            this.menu_turnoff.Image = global::_4team_project.Properties.Resources.turnoff;
            this.menu_turnoff.Name = "menu_turnoff";
            this.menu_turnoff.Size = new System.Drawing.Size(156, 26);
            this.menu_turnoff.Text = "시스템 종료";
            this.menu_turnoff.Click += new System.EventHandler(this.menu_turnoff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // menu_standby
            // 
            this.menu_standby.Image = global::_4team_project.Properties.Resources.standby;
            this.menu_standby.Name = "menu_standby";
            this.menu_standby.Size = new System.Drawing.Size(156, 26);
            this.menu_standby.Text = "대기모드";
            this.menu_standby.Click += new System.EventHandler(this.menu_standby_Click);
            // 
            // menu_hinernate
            // 
            this.menu_hinernate.Image = global::_4team_project.Properties.Resources.hibernate;
            this.menu_hinernate.Name = "menu_hinernate";
            this.menu_hinernate.Size = new System.Drawing.Size(156, 26);
            this.menu_hinernate.Text = "최대절전";
            this.menu_hinernate.Click += new System.EventHandler(this.menu_hinernate_Click);
            // 
            // 로그기록보기ToolStripMenuItem
            // 
            this.로그기록보기ToolStripMenuItem.Image = global::_4team_project.Properties.Resources.로그;
            this.로그기록보기ToolStripMenuItem.Name = "로그기록보기ToolStripMenuItem";
            this.로그기록보기ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.로그기록보기ToolStripMenuItem.Text = "절전양 보기";
            this.로그기록보기ToolStripMenuItem.Click += new System.EventHandler(this.로그기록보기ToolStripMenuItem_Click);
            // 
            // finish
            // 
            this.finish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.finish.Font = new System.Drawing.Font("한컴 윤체 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.finish.Image = ((System.Drawing.Image)(resources.GetObject("finish.Image")));
            this.finish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(44, 26);
            this.finish.Text = "종료";
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(105, 48);
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.showToolStripMenuItem.Text = "show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // L_ip
            // 
            this.L_ip.AutoSize = true;
            this.L_ip.BackColor = System.Drawing.Color.Transparent;
            this.L_ip.Location = new System.Drawing.Point(120, 321);
            this.L_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_ip.Name = "L_ip";
            this.L_ip.Size = new System.Drawing.Size(43, 21);
            this.L_ip.TabIndex = 9;
            this.L_ip.Text = "???";
            // 
            // L_screen_s
            // 
            this.L_screen_s.AutoSize = true;
            this.L_screen_s.BackColor = System.Drawing.Color.Transparent;
            this.L_screen_s.Location = new System.Drawing.Point(120, 279);
            this.L_screen_s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_screen_s.Name = "L_screen_s";
            this.L_screen_s.Size = new System.Drawing.Size(57, 21);
            this.L_screen_s.TabIndex = 10;
            this.L_screen_s.Text = "label1";
            // 
            // L_standby_s
            // 
            this.L_standby_s.AutoSize = true;
            this.L_standby_s.BackColor = System.Drawing.Color.Transparent;
            this.L_standby_s.Location = new System.Drawing.Point(121, 247);
            this.L_standby_s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_standby_s.Name = "L_standby_s";
            this.L_standby_s.Size = new System.Drawing.Size(57, 21);
            this.L_standby_s.TabIndex = 11;
            this.L_standby_s.Text = "label1";
            // 
            // L_monitoroff_s
            // 
            this.L_monitoroff_s.AutoSize = true;
            this.L_monitoroff_s.BackColor = System.Drawing.Color.Transparent;
            this.L_monitoroff_s.Location = new System.Drawing.Point(125, 215);
            this.L_monitoroff_s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_monitoroff_s.Name = "L_monitoroff_s";
            this.L_monitoroff_s.Size = new System.Drawing.Size(57, 21);
            this.L_monitoroff_s.TabIndex = 13;
            this.L_monitoroff_s.Text = "label1";
            // 
            // t_hibernate
            // 
            this.t_hibernate.Interval = 60000;
            this.t_hibernate.Tick += new System.EventHandler(this.t_hibernate_Tick);
            // 
            // t_off
            // 
            this.t_off.Interval = 60000;
            this.t_off.Tick += new System.EventHandler(this.t_off_Tick);
            // 
            // t_mo
            // 
            this.t_mo.Interval = 600000;
            this.t_mo.Tick += new System.EventHandler(this.t_mo_Tick);
            // 
            // t_ss
            // 
            this.t_ss.Interval = 600000;
            this.t_ss.Tick += new System.EventHandler(this.t_ss_Tick);
            // 
            // t_sb
            // 
            this.t_sb.Interval = 600000;
            this.t_sb.Tick += new System.EventHandler(this.t_sb_Tick);
            // 
            // mailer
            // 
            this.mailer.Tick += new System.EventHandler(this.mailer_Tick);
            // 
            // mailertime
            // 
            this.mailertime.AutoSize = true;
            this.mailertime.Location = new System.Drawing.Point(555, 347);
            this.mailertime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailertime.Name = "mailertime";
            this.mailertime.Size = new System.Drawing.Size(22, 21);
            this.mailertime.TabIndex = 21;
            this.mailertime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 347);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "경고메일카운트";
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.Transparent;
            this.b_cancel.Location = new System.Drawing.Point(506, 302);
            this.b_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(107, 40);
            this.b_cancel.TabIndex = 22;
            this.b_cancel.Text = "취소";
            this.b_cancel.UseVisualStyleBackColor = false;
            // 
            // b_ok
            // 
            this.b_ok.BackColor = System.Drawing.Color.Transparent;
            this.b_ok.Location = new System.Drawing.Point(391, 302);
            this.b_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(107, 40);
            this.b_ok.TabIndex = 21;
            this.b_ok.Text = "예약";
            this.b_ok.UseVisualStyleBackColor = false;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // time_off
            // 
            this.time_off.Enabled = false;
            this.time_off.Location = new System.Drawing.Point(479, 417);
            this.time_off.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_off.Name = "time_off";
            this.time_off.Size = new System.Drawing.Size(131, 40);
            this.time_off.TabIndex = 20;
            this.time_off.Text = "종료시간입력";
            this.time_off.UseVisualStyleBackColor = true;
            this.time_off.Click += new System.EventHandler(this.time_off_Click);
            // 
            // time_hibernate
            // 
            this.time_hibernate.Enabled = false;
            this.time_hibernate.Location = new System.Drawing.Point(479, 378);
            this.time_hibernate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_hibernate.Name = "time_hibernate";
            this.time_hibernate.Size = new System.Drawing.Size(131, 40);
            this.time_hibernate.TabIndex = 17;
            this.time_hibernate.Text = "절전시간입력";
            this.time_hibernate.UseVisualStyleBackColor = true;
            this.time_hibernate.Click += new System.EventHandler(this.time_hibernate_Click);
            // 
            // chk_off
            // 
            this.chk_off.AutoSize = true;
            this.chk_off.Location = new System.Drawing.Point(422, 417);
            this.chk_off.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_off.Name = "chk_off";
            this.chk_off.Size = new System.Drawing.Size(57, 25);
            this.chk_off.TabIndex = 19;
            this.chk_off.Text = "사용";
            this.chk_off.UseVisualStyleBackColor = true;
            this.chk_off.CheckedChanged += new System.EventHandler(this.chk_off_CheckedChanged);
            // 
            // chk_hibernate
            // 
            this.chk_hibernate.AutoSize = true;
            this.chk_hibernate.Location = new System.Drawing.Point(422, 382);
            this.chk_hibernate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_hibernate.Name = "chk_hibernate";
            this.chk_hibernate.Size = new System.Drawing.Size(57, 25);
            this.chk_hibernate.TabIndex = 17;
            this.chk_hibernate.Text = "사용";
            this.chk_hibernate.UseVisualStyleBackColor = true;
            this.chk_hibernate.CheckedChanged += new System.EventHandler(this.chk_hibernate_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(334, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "시스템종료";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(348, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "최대절전";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.opt_sb20);
            this.groupBox3.Controls.Add(this.opt_sb10);
            this.groupBox3.Controls.Add(this.opt_sb30);
            this.groupBox3.Controls.Add(this.opt_sb0);
            this.groupBox3.Location = new System.Drawing.Point(284, 225);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(326, 75);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "대기모드";
            // 
            // opt_sb20
            // 
            this.opt_sb20.AutoSize = true;
            this.opt_sb20.Location = new System.Drawing.Point(151, 23);
            this.opt_sb20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_sb20.Name = "opt_sb20";
            this.opt_sb20.Size = new System.Drawing.Size(63, 25);
            this.opt_sb20.TabIndex = 3;
            this.opt_sb20.Text = "20분";
            this.opt_sb20.UseVisualStyleBackColor = true;
            this.opt_sb20.CheckedChanged += new System.EventHandler(this.opt_sb20_CheckedChanged);
            // 
            // opt_sb10
            // 
            this.opt_sb10.AutoSize = true;
            this.opt_sb10.Location = new System.Drawing.Point(84, 23);
            this.opt_sb10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_sb10.Name = "opt_sb10";
            this.opt_sb10.Size = new System.Drawing.Size(61, 25);
            this.opt_sb10.TabIndex = 2;
            this.opt_sb10.Text = "10분";
            this.opt_sb10.UseVisualStyleBackColor = true;
            this.opt_sb10.CheckedChanged += new System.EventHandler(this.opt_sb10_CheckedChanged);
            // 
            // opt_sb30
            // 
            this.opt_sb30.AutoSize = true;
            this.opt_sb30.Location = new System.Drawing.Point(230, 23);
            this.opt_sb30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_sb30.Name = "opt_sb30";
            this.opt_sb30.Size = new System.Drawing.Size(63, 25);
            this.opt_sb30.TabIndex = 1;
            this.opt_sb30.Text = "30분";
            this.opt_sb30.UseVisualStyleBackColor = true;
            this.opt_sb30.CheckedChanged += new System.EventHandler(this.opt_sb30_CheckedChanged);
            // 
            // opt_sb0
            // 
            this.opt_sb0.AutoSize = true;
            this.opt_sb0.Checked = true;
            this.opt_sb0.Location = new System.Drawing.Point(4, 30);
            this.opt_sb0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_sb0.Name = "opt_sb0";
            this.opt_sb0.Size = new System.Drawing.Size(56, 25);
            this.opt_sb0.TabIndex = 0;
            this.opt_sb0.TabStop = true;
            this.opt_sb0.Text = "없음";
            this.opt_sb0.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.opt_mo30);
            this.groupBox2.Controls.Add(this.opt_mo10);
            this.groupBox2.Controls.Add(this.opt_mo20);
            this.groupBox2.Controls.Add(this.opt_mo0);
            this.groupBox2.Location = new System.Drawing.Point(284, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(334, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모니터끄기";
            // 
            // opt_mo30
            // 
            this.opt_mo30.AutoSize = true;
            this.opt_mo30.Location = new System.Drawing.Point(239, 26);
            this.opt_mo30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_mo30.Name = "opt_mo30";
            this.opt_mo30.Size = new System.Drawing.Size(63, 25);
            this.opt_mo30.TabIndex = 20;
            this.opt_mo30.Text = "30분";
            this.opt_mo30.UseVisualStyleBackColor = true;
            this.opt_mo30.CheckedChanged += new System.EventHandler(this.opt_mo30_CheckedChanged);
            // 
            // opt_mo10
            // 
            this.opt_mo10.AutoSize = true;
            this.opt_mo10.Location = new System.Drawing.Point(84, 26);
            this.opt_mo10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_mo10.Name = "opt_mo10";
            this.opt_mo10.Size = new System.Drawing.Size(61, 25);
            this.opt_mo10.TabIndex = 19;
            this.opt_mo10.Text = "10분";
            this.opt_mo10.UseVisualStyleBackColor = true;
            this.opt_mo10.CheckedChanged += new System.EventHandler(this.opt_mo10_CheckedChanged);
            // 
            // opt_mo20
            // 
            this.opt_mo20.AutoSize = true;
            this.opt_mo20.Location = new System.Drawing.Point(160, 26);
            this.opt_mo20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_mo20.Name = "opt_mo20";
            this.opt_mo20.Size = new System.Drawing.Size(63, 25);
            this.opt_mo20.TabIndex = 18;
            this.opt_mo20.Text = "20분";
            this.opt_mo20.UseVisualStyleBackColor = true;
            this.opt_mo20.CheckedChanged += new System.EventHandler(this.opt_mo20_CheckedChanged);
            // 
            // opt_mo0
            // 
            this.opt_mo0.AutoSize = true;
            this.opt_mo0.Checked = true;
            this.opt_mo0.Location = new System.Drawing.Point(9, 26);
            this.opt_mo0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_mo0.Name = "opt_mo0";
            this.opt_mo0.Size = new System.Drawing.Size(56, 25);
            this.opt_mo0.TabIndex = 17;
            this.opt_mo0.TabStop = true;
            this.opt_mo0.Text = "없음";
            this.opt_mo0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.opt_ss30);
            this.groupBox1.Controls.Add(this.opt_ss20);
            this.groupBox1.Controls.Add(this.opt_ss10);
            this.groupBox1.Controls.Add(this.opt_ss0);
            this.groupBox1.Location = new System.Drawing.Point(284, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(334, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "화면보호기";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // opt_ss30
            // 
            this.opt_ss30.AutoSize = true;
            this.opt_ss30.Location = new System.Drawing.Point(239, 35);
            this.opt_ss30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_ss30.Name = "opt_ss30";
            this.opt_ss30.Size = new System.Drawing.Size(63, 25);
            this.opt_ss30.TabIndex = 6;
            this.opt_ss30.Text = "30분";
            this.opt_ss30.UseVisualStyleBackColor = true;
            this.opt_ss30.CheckedChanged += new System.EventHandler(this.opt_ss30_CheckedChanged);
            // 
            // opt_ss20
            // 
            this.opt_ss20.AutoSize = true;
            this.opt_ss20.Location = new System.Drawing.Point(160, 35);
            this.opt_ss20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_ss20.Name = "opt_ss20";
            this.opt_ss20.Size = new System.Drawing.Size(63, 25);
            this.opt_ss20.TabIndex = 5;
            this.opt_ss20.Text = "20분";
            this.opt_ss20.UseVisualStyleBackColor = true;
            this.opt_ss20.CheckedChanged += new System.EventHandler(this.opt_ss20_CheckedChanged);
            // 
            // opt_ss10
            // 
            this.opt_ss10.AutoSize = true;
            this.opt_ss10.Location = new System.Drawing.Point(84, 35);
            this.opt_ss10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_ss10.Name = "opt_ss10";
            this.opt_ss10.Size = new System.Drawing.Size(61, 25);
            this.opt_ss10.TabIndex = 4;
            this.opt_ss10.Text = "10분";
            this.opt_ss10.UseVisualStyleBackColor = true;
            this.opt_ss10.CheckedChanged += new System.EventHandler(this.opt_ss10_CheckedChanged);
            // 
            // opt_ss0
            // 
            this.opt_ss0.AutoSize = true;
            this.opt_ss0.Checked = true;
            this.opt_ss0.Location = new System.Drawing.Point(9, 35);
            this.opt_ss0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_ss0.Name = "opt_ss0";
            this.opt_ss0.Size = new System.Drawing.Size(56, 25);
            this.opt_ss0.TabIndex = 4;
            this.opt_ss0.TabStop = true;
            this.opt_ss0.Text = "없음";
            this.opt_ss0.UseVisualStyleBackColor = true;
            // 
            // reservation
            // 
            this.reservation.AutoSize = true;
            this.reservation.BackColor = System.Drawing.Color.Transparent;
            this.reservation.Font = new System.Drawing.Font("Baskerville BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation.ForeColor = System.Drawing.Color.Black;
            this.reservation.Location = new System.Drawing.Point(304, 42);
            this.reservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(113, 23);
            this.reservation.TabIndex = 0;
            this.reservation.Text = "reservation";
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4team_project.Properties.Resources.c__배경1;
            this.ClientSize = new System.Drawing.Size(619, 459);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chk_off);
            this.Controls.Add(this.time_off);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.time_hibernate);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.chk_hibernate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mailertime);
            this.Controls.Add(this.L_monitoroff_s);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.L_standby_s);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_screen_s);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.L_ip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_name);
            this.Font = new System.Drawing.Font("한컴 윤체 L", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton menu;
        private System.Windows.Forms.ToolStripMenuItem menu_monitoroff;
        private System.Windows.Forms.ToolStripMenuItem menu_turnoff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_standby;
        private System.Windows.Forms.ToolStripMenuItem menu_hinernate;
        private System.Windows.Forms.ToolStripButton finish;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label L_ip;
        private System.Windows.Forms.Label L_screen_s;
        private System.Windows.Forms.Label L_standby_s;
        private System.Windows.Forms.Label L_monitoroff_s;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label reservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_ss0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt_ss30;
        private System.Windows.Forms.RadioButton opt_ss20;
        private System.Windows.Forms.RadioButton opt_ss10;
        private System.Windows.Forms.RadioButton opt_mo30;
        private System.Windows.Forms.RadioButton opt_mo10;
        private System.Windows.Forms.RadioButton opt_mo20;
        private System.Windows.Forms.RadioButton opt_mo0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton opt_sb20;
        private System.Windows.Forms.RadioButton opt_sb10;
        private System.Windows.Forms.RadioButton opt_sb30;
        private System.Windows.Forms.RadioButton opt_sb0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_off;
        private System.Windows.Forms.CheckBox chk_hibernate;
        private System.Windows.Forms.Button time_off;
        private System.Windows.Forms.Button time_hibernate;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Timer t_hibernate;
        private System.Windows.Forms.Timer t_off;
        private System.Windows.Forms.Timer t_mo;
        private System.Windows.Forms.Timer t_ss;
        private System.Windows.Forms.Timer t_sb;
        private System.Windows.Forms.Timer mailer;
        private System.Windows.Forms.Label mailertime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem 로그기록보기ToolStripMenuItem;
    }
}