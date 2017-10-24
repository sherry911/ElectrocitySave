using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _4team_project
{
    public partial class login : Form
    {
        public String[] para;
        public bool loginstate;
        public login()
        {
            InitializeComponent();
        }

        private void B_join_Click(object sender, EventArgs e)
        {
            join member_join = new join();
            member_join.ShowDialog();
        }
        
        private void B_login_Click(object sender, EventArgs e)
        {
            
            String extension = ".ini";
            //String logextension =".txt";
            String path;
            String text;
            if(T_ID.Text.Length ==0)
            {
                MessageBox.Show("아이디를 입력해주세요");
            }
            else
            {
                path = T_ID.Text + extension;
                loginstate = false;
                if(File.Exists(path))
                {
                    string[] delim = {":","/","\r\n"};
                    text = File.ReadAllText(path);
                    para =text.Split(delim, StringSplitOptions.None);
                    MessageBox.Show("로그인 되셨습니다.");
                    loginstate = true;
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("회원가입을 해주세요");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        
    }
}
