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

namespace _4team_project
{
    public partial class log : Form
    {
        HTTPWebComm comm = new HTTPWebComm();
        public static TimeSpan TotalTimeSpan;
        public static TimeSpan TodayTimeSpan;
        public static DateTime LastSaveData;
        public static TimeSpanConverter tc;
        String id = new_login.id;
        public log()
        {
            InitializeComponent();
            DateTime wakeUp = new DateTime();
            DateTime shutDown = new DateTime();
            DateTime hibernate = new DateTime();
            string[] delim = { "<BR>", "\r\n" };
            String resultStr;
            comm.SetURL("http://210.94.194.100:20151/log.asp");
            comm.SetMessage("id=" + id + "&cmd=read");
            comm.Request();
            resultStr = comm.Response();
            string[] s = resultStr.Split(new char[] { '|', '<', '>' });
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == "BR") // log에 BR이 나올 경우 줄바꿈
                {
                    textBox1.Text += "\n";
                }
                else // 로그 분리를 하면서 분리되어 없어진 '|'를 다시 삽입
                {
                    textBox1.Text += s[i] + "|";
                }
                if (s[i] == "WAKEUP") // 명령어가 WAKEUP일경우
                {
                    DateTime.TryParse(s[i+1], out wakeUp);
                 
                }
                if (s[i] == "SHUTDOWN") // 명령어가 SHUTDOWN일경우
                {
                    DateTime.TryParse(s[i + 1], out shutDown); // 그 다음 배열의 내용을 DateTime으로 변환
                }
                if(s[i]=="HIBERNATE")
                {
                    DateTime.TryParse(s[i + 1], out hibernate);                    
                }
            }
            DateTime startSuspend;
            DateTime endSuspend = DateTime.Now;
         
            DateTimeConverter dtc = new DateTimeConverter();
            startSuspend = (DateTime)dtc.ConvertFromString(shutDown.ToString("HH:mm:ss"));
            endSuspend = (DateTime)dtc.ConvertFromString(endSuspend.ToString("HH:mm:ss"));
            TotalTimeSpan += endSuspend.Subtract(startSuspend);

            double saveelec=(TotalTimeSpan.TotalSeconds * 0.056 / 1000)*0.424;
            textBox1.Text = "절감 전기량 : ";
            textBox1.AppendText((TotalTimeSpan.TotalSeconds * 0.056 / 1000).ToString()+"KWh\n");
            textBox1.AppendText("절약 배출 CO2량 : ");
            textBox1.AppendText(((int)(saveelec)).ToString()+"KG\n");
            saveelec = saveelec / 2.77;
            textBox1.AppendText("절약 나무 수 : ");
            textBox1.AppendText(((int)(saveelec)).ToString() + "그루\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
