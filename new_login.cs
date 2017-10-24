using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4team_project
{
    public partial class new_login : Form
    {
        public static string id=null, name=null, email=null;
        public static bool loginstate = false;
        register res = new register();
        public StreamReader stream_read;
       
        public new_login()
        {
            InitializeComponent();
        }

        private void b_new_Click(object sender, EventArgs e)//새사용자등록
        {
            res.ShowDialog();
            Close();
        }

        private void b_exist_Click(object sender, EventArgs e)//기존사용자
        {


            stream_read = new StreamReader(res.filePath);
            string temp = null; //읽어온줄을 임시로 저장하는 temp string변수
            while (stream_read.Peek() >-1)//읽어온 줄이 null이 아니라면
            {
                temp = stream_read.ReadLine();
                string[] s = temp.Split('+');
                email = s[0];
                id = s[1];
                name = s[2];
            }
            if (id == null || name == null || email == null)
            {
                MessageBox.Show("사용자 등록이 되지 않았습니다. 사용자를 등록하세요");
            }
            else
            {
               
                loginstate = true;
                Close();
            }
          
        }

        private void new_login_Load(object sender, EventArgs e)
        {

        }
    }
}
