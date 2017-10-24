using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;
using HTTPComm;
namespace _4team_project
{
    public partial class join : Form
    {
        HTTPWebComm comm = new HTTPWebComm();
        public join()
        {
            InitializeComponent();
        }

        private void B_submit_Click(object sender, EventArgs e)
        {
            if (T_id.Text.Length!=0  && T_name.Text.Length != 0 && T_ip.Text.Length != 0)
            {
                String extension = ".ini";
                String logextension = ".txt";
                String path = T_id.Text + extension;
                String logpath = T_id.Text + "_log" + logextension;
                String text;
                String text2 = T_id.Text + "로그파일입니다.\r\n";
                String resultStr;
                if (File.Exists(path) == false && File.Exists(logpath)== false)
                {
                    text = "id:" + T_id.Text + "\r\n"
                        + "name:" + T_name.Text + "\r\n"
                        + "ip:" + T_ip.Text + "\r\n"
                        + "screen:off/0\r\n"
                        + "monitoroff:off/0\r\n"
                        + "systemoff:off/0\r\n"
                        + "standby:off/0\r\n"
                        + "hibernate:off/0000/00/00/00:00:00\r\n"
                        + "systemoff:off/0000/00/00/00:00:00\r\n";
                    comm.SetURL("http://210.94.194.100:20151/registerUser.asp");
                    comm.SetMessage("id="+T_id.Text);
                    comm.Request();
                    resultStr = comm.Response();
                    String[] error = resultStr.Split(':');//resultStr이 error라면 뒤에 메시지와 상관없이 Error만 남게 될것
                    if (resultStr.Equals("ERROR"))
                    {
                    }
                    else
                    {
                        comm.SetURL("http://210.94.194.100:20151/log.asp");
                        comm.SetMessage("id="+T_id.Text+"&cmd=read");
                        comm.Request();
                        resultStr = comm.Response();
                        //BR로 스플릿하기위해
                        String[] cutbr = new String[] { "<BR>" };

                        String[] returnval = resultStr.Split(cutbr, StringSplitOptions.None);//<BR>로 스플릿
                        for (int i = 0; i < returnval.Length; i++)
                            text2 += returnval[i] + "\r\n";
                    }
                    File.WriteAllText(path, text);
                    File.WriteAllText(logpath, text2);
                    MessageBox.Show("회원가입되었습니다");
                    Close();
                }
                else
                {
                    MessageBox.Show("존재하는 아이디 입니다.");
                }
            }
            else
            {
                MessageBox.Show("모든 값을 입력해 주세요");
            }
        }
    }
}
