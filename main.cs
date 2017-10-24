using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MouseKeyboardLibrary;
using Timer_TCPServer;
using System.Text;
using System.Windows.Forms;
using HTTPComm;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;

namespace _4team_project
{
    public partial class main : Form
    {
        HTTPWebComm comm = new HTTPWebComm();
        KeyboardHook keyboardHook = new KeyboardHook();
        MouseHook mouseHook = new MouseHook();
        register res = new register();
        res_hibernate res_hib = new res_hibernate();
        res_turnoff res_turnoff = new res_turnoff();
        res_off res_off = new res_off();
        new_login N_LOG = new new_login();
        log LOG = new log();
        TCPServer tcp;
        string execute_mo;
        string execute_sb;
        string execute_ss;
        string name;
        string id;
        string ip;
        string email;
        int idletime;
        public bool loginstate;
        public main()
        {
            InitializeComponent();
        }

        

        public void Sendmessage(string message)
        {
           if(message=="off")
           {
               menu_turnoff_Click(null, null);
           }
        }
        public static string Client_IP// ip가져오는 메소드
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());//IP주소와 호스트 네임을 가져온다.
                string ClientIP = string.Empty;
                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)//IP v4만 가져온다
                    {
                        ClientIP = host.AddressList[i].ToString();
                    }
                }
                return ClientIP;
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
                  
            
            //loginstate = false;
            N_LOG.ShowDialog();
            this.Hide();
            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.Start();// 폼이 실행되면 바로 키보드후크 실행
            mouseHook.Start();
            tcp = new TCPServer(this);
            tcp.Start();
            mailer.Interval = 1000;
            
            if (new_login.loginstate == false)
            {
                Application.ExitThread();
            }
            
            L_monitoroff_s.Text = "off"; //모니터가 꺼지지 않음
            L_standby_s.Text = "off";//대기모드가 아님
           
            
            loginstate = false;
           
            id =new_login.id;
            name=L_name.Text = new_login.name;
            email = L_ip.Text = new_login.email;
            L_screen_s.Text = "off";
            L_monitoroff_s.Text = "off";
            L_standby_s.Text = "off";
            idletime = 0;
            mailer.Enabled = true;
            /*
            if (LOGIN.para[7] == "off")
                L_screen.Text = "";
            else
                L_screen.Text = LOGIN.para[8];
            if (LOGIN.para[10] == "off")
                L_monitoroff.Text = "";
            else
                L_monitoroff.Text = LOGIN.para[11];
            if (LOGIN.para[13] == "off")
                L_systemoff.Text = "";
            else
                L_systemoff.Text = LOGIN.para[14];
            if (LOGIN.para[16] == "off")
                L_standby.Text = "";
            else
                L_standby.Text = LOGIN.para[17]; 
             * */

        }
         void keyboardHook_KeyUp(object sender, KeyEventArgs e)// 키보드를 누르고 때었을때 이벤트
        {
            BrightnessController.SetBrightness(130);// 밝기 복귀
            mailer.Enabled = false;// 타이머 종료
            idletime = 0; // 타이머 초기화
            mailer.Enabled = true;// 타이머 재가동
        }
         void keyboardHook_KeyDown(object sender, KeyEventArgs e)// 키보드를 눌렀을 때 이벤트
         {
             BrightnessController.SetBrightness(130);//밝기 복귀
             mailer.Enabled = false;// 타이머 종료
             idletime = 0; // 타이머 초기화
             mailer.Enabled = true;// 타이머 재가동
         }
        void mouseHook_MouseMove(object sender, MouseEventArgs e)// 마우스를 움직였을 때 일어나는 이벤트
        {
            BrightnessController.SetBrightness(130);// 밝기 복귀
            mailer.Enabled = false;//타이머종료
            idletime = 0; // 타이머 초기화
            mailer.Enabled = true;// 타이머 재가동
        }
        private void menu_monitoroff_Click(object sender, EventArgs e)//메뉴->monitor off
        {

            String resultStr;
            comm.SetURL("http://210.94.194.100:20151/log.asp");
            comm.SetMessage("id=" + id + "&cmd=write&action=sleep");
            comm.Request();
            resultStr = comm.Response();
            Process.Start("nircmd.exe", "monitor off"); //컴퓨터의 전원을 끈다
            
        }
        private void menu_turnoff_Click(object sender, EventArgs e)//시스템종료
        {
            String resultStr;
            comm.SetURL("http://210.94.194.100:20151/log.asp");
            comm.SetMessage("id=" + id + "&cmd=write&action=shutdown");
            comm.Request();
            resultStr = comm.Response();
            Process.Start("nircmd.exe", "exitwin poweroff"); //컴퓨터의 전원을 끈다
            
        }
        private void showToolStripMenuItem1_Click(object sender, EventArgs e) //tray메뉴에서 show버튼
        {
            this.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)//tray메뉴에서 exit버튼
        {
            Application.ExitThread();
        }

        private void menu_standby_Click(object sender, EventArgs e)//메뉴->대기모드
        {
            String resultStr;
            comm.SetURL("http://210.94.194.100:20151/log.asp");
            comm.SetMessage("id=" + id + "&cmd=write&action=suspend");
            comm.Request();
            resultStr = comm.Response();
            Process.Start("nircmd.exe", "standby"); //대기모드 실행
            
        }

        private void menu_hinernate_Click(object sender, EventArgs e)//메뉴->절전모드
        {
            String resultStr;
            comm.SetURL("http://210.94.194.100:20151/log.asp");
            comm.SetMessage("id=" + id + "&cmd=write&action=hibernate");
            comm.Request();
            resultStr = comm.Response();
            Process.Start(fileName: "rundll32", arguments: "powrprof.dll, SetSuspendState");
            
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void time_hibernate_Click(object sender, EventArgs e)
        {
            
           // res_hib.Owner = this;
            res_hib.ShowDialog();
            t_hibernate.Start(); //절전모드타이머시작
            
        }

        private void t_hibernate_Tick(object sender, EventArgs e)
        {
            if (res_hib.execute != null)
            {
                if (DateTime.Now.ToString("HH:mm") == res_hib.execute)
                {
                    String resultStr;
                    comm.SetURL("http://210.94.194.100:20151/log.asp");
                    comm.SetMessage("id=" + id + "&cmd=write&action=hibernate");
                    comm.Request();
                    resultStr = comm.Response();
                    Process.Start(fileName: "rundll32", arguments: "powrprof.dll, SetSuspendState");
                    t_hibernate.Stop();
                }
            }
        }

        private void chk_hibernate_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hibernate.Checked)//체크가 되면
            {
                time_hibernate.Enabled = true;
            }
            else
                time_hibernate.Enabled = false;
            
        }

        private void chk_off_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_off.Checked)
            {
                time_off.Enabled = true;
            }
            else time_off.Enabled = false;
        }

        private void time_off_Click(object sender, EventArgs e)
        {
           
            res_turnoff.ShowDialog();
            t_off.Start(); //끄기타이머시작
        }

        private void t_off_Tick(object sender, EventArgs e)
        {
            if (res_turnoff.execute != null)
            {
                if (DateTime.Now.ToString("HH:mm") == res_turnoff.execute)
                {
                    String resultStr;
                    comm.SetURL("http://210.94.194.100:20151/log.asp");
                    comm.SetMessage("id=" + id + "&cmd=write&action=shutdown");
                    comm.Request();
                    resultStr = comm.Response();
                    Process.Start("nircmd.exe", "exitwin poweroff"); //컴퓨터의 전원을 끈다
                    
                    t_off.Stop();
                }
            }
        }

        private void b_ok_Click(object sender, EventArgs e)//예약버튼을 누르면
        {
           
            if (opt_mo10.Checked || opt_mo20.Checked || opt_mo30.Checked)//모니터끄기가 체크되면
            {
                
                if (opt_mo10.Checked)
                {
                    execute_mo = DateTime.Now.AddMinutes(10).ToString();//실행시간설정
                }
                if (opt_mo20.Checked)
                {
                   
                    execute_mo = DateTime.Now.AddMinutes(20).ToString();//실행시간설정
                }
                if (opt_mo30.Checked)
                {
                    
                    execute_mo = DateTime.Now.AddMinutes(30).ToString();//실행시간설정
                }
                L_monitoroff_s.Text = "on";
                t_mo.Start();
               
            }
            if (opt_sb10.Checked || opt_sb20.Checked || opt_sb30.Checked)
            {
                if (opt_sb10.Checked)
                {
                   
                    execute_sb = DateTime.Now.AddMinutes(10).ToString();//실행시간설정
                }
                if (opt_sb20.Checked)
                {
                    execute_sb = DateTime.Now.AddMinutes(20).ToString();//실행시간설정
                }
                if (opt_sb30.Checked)
                {
                    execute_sb = DateTime.Now.AddMinutes(30).ToString();//실행시간설정
                }
                L_standby_s.Text = "on";
                t_sb.Start(); //타이머 시작
            }

            if (opt_ss10.Checked || opt_ss20.Checked || opt_ss30.Checked)
            {
                if (opt_ss10.Checked)
                {
                    execute_ss = DateTime.Now.AddMinutes(10).ToString();//실행시간설정
                }
                if (opt_ss20.Checked)
                {
                    execute_ss = DateTime.Now.AddMinutes(20).ToString();//실행시간설정
                }
                if (opt_ss30.Checked)
                {
                    execute_ss = DateTime.Now.AddMinutes(30).ToString();//실행시간설정
                }
                L_screen_s.Text = "on";
                t_ss.Start(); //타이머 시작
            }
            MessageBox.Show("예약완료되었습니다!");

        }

        private void t_mo_Tick(object sender, EventArgs e)//10분마다체크(interval=600,000)
        {
            if (execute_mo == DateTime.Now.ToString())
            {
                String resultStr;
                comm.SetURL("http://210.94.194.100:20151/log.asp");
                comm.SetMessage("id=" + id + "&cmd=write&action=sleep");
                comm.Request();
                resultStr = comm.Response();
                Process.Start("nircmd.exe", "monitor off"); //컴퓨터의 전원을 끈다
                L_monitoroff_s.Text = "on"; //모니터가 꺼졌다고 표시
                t_mo.Stop();
            }
        }

        private void t_ss_Tick(object sender, EventArgs e)
        {
            if (execute_ss == DateTime.Now.ToString())
            {
                Process.Start("nircmd.exe", "screensaver"); //컴퓨터의 전원을 끈다
                //L_screensaver_s.Text = "on"; //모니터가 꺼졌다고 표시
                t_ss.Stop();

            }
        }

        private void t_sb_Tick(object sender, EventArgs e)
        {
            if (execute_sb == DateTime.Now.ToString())
            {
                String resultStr;
                comm.SetURL("http://210.94.194.100:20151/log.asp");
                comm.SetMessage("id=" + id + "&cmd=write&action=suspend");
                comm.Request();
                resultStr = comm.Response();
                Process.Start("nircmd.exe", "standby"); //대기모드 실행
                L_standby_s.Text = "on"; //컴퓨터가 대기모드라고 표시
                t_sb.Stop();
            }
        }

        private void opt_ss10_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_ss10.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb10.Enabled = false;
                opt_mo10.Enabled = false;
            }
            else
            {
                opt_sb10.Enabled = true;
                opt_mo10.Enabled = true;
            }
        }

        private void opt_ss20_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_ss20.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb20.Enabled = false;
                opt_mo20.Enabled = false;
            }
            else
            {
                opt_sb20.Enabled = true;
                opt_mo20.Enabled = true;
            }
        }

        private void opt_ss30_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_ss30.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb30.Enabled = false;
                opt_mo30.Enabled = false;
            }
            else
            {
                opt_sb30.Enabled = true;
                opt_mo30.Enabled = true;
            } 
        }

        private void opt_mo10_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_mo10.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb10.Enabled = false;
                opt_ss10.Enabled = false;
            }
            else
            {
                opt_sb10.Enabled = true;
                opt_ss10.Enabled = true;
            }
        }

        private void opt_mo20_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_mo20.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb20.Enabled = false;
                opt_ss20.Enabled = false;
            }
            else
            {
                opt_sb20.Enabled = true;
                opt_ss20.Enabled = true;
            }
        }

        private void opt_mo30_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_mo30.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_sb30.Enabled = false;
                opt_ss30.Enabled = false;
            }
            else
            {
                opt_sb30.Enabled = true;
                opt_ss30.Enabled = true;
            }
        }

        private void opt_sb10_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_sb10.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_mo10.Enabled = false;
                opt_ss10.Enabled = false;
            }
            else
            {
                opt_mo10.Enabled = true;
                opt_ss10.Enabled = true;
            }
        }

        private void opt_sb20_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_sb20.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_mo20.Enabled = false;
                opt_ss20.Enabled = false;
            }
            else
            {
                opt_mo20.Enabled = true;
                opt_ss20.Enabled = true;
            }
        }

        private void opt_sb30_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_sb30.Checked)//같은시간에 여러개의 기능을 체크하는 것을 방지
            {
                opt_mo30.Enabled = false;
                opt_ss30.Enabled = false;
            }
            else
            {
                opt_mo30.Enabled = true;
                opt_ss30.Enabled = true;
            }
        }
        
        private void mailer_Tick(object sender, EventArgs e)
        {// 타이머 가동
            idletime = idletime + 1;// 1초증가
            
            mailertime.Text = idletime.ToString();//현황보여주는 나중에는 지울 예정
            if(idletime==180)// idletime이 3분이 된다면 
            {
                BrightnessController.SetBrightness(50);// 어둡게
            }
            if(idletime == 1800)// 일단 임시로 30분이 된다면 메일 알림으로 이 초는 나중에 바꾸는 게 현실적
            {
                ip = Client_IP;// 지금 사용하고 있는 컴퓨터의 IP를 가져옴
                comm.SetURL("http://210.94.181.168/sendcommand.php");// 서버로 ip,id, name을 보내서 SMTP실행
                comm.SetMessage("ip=" + ip + "&id=" + id+"&name="+name);
                comm.Request();
                idletime = 0;
            }
        }



        private void finish_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void reservation_Click(object sender, EventArgs e)
        {

        }

        private void 로그기록보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOG.ShowDialog();
        }   
    }
}
