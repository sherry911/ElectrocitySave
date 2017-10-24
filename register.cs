using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HTTPComm;
namespace _4team_project
{
    public partial class register : Form
    {
        HTTPWebComm comm = new HTTPWebComm();
      
        public StreamWriter stream_write;
        public string filePath="register.txt";
        public register()
        {
            InitializeComponent();

        }

        private void register_id_Click(object sender, EventArgs e)
        {
           
           
            new_login.email = input_email.Text;
            new_login.name = input_name.Text;
            new_login.id = input_id.Text;
           
            if (new_login.email != null && new_login.name != null && new_login.id != null)
            {
                System.IO.File.WriteAllText(filePath, null);
                new_login.loginstate = true;
                stream_write = new StreamWriter(filePath);
                stream_write.Write(new_login.email + "+" + new_login.id + "+" + new_login.name);
                stream_write.Close();
                comm.SetURL("http://210.94.181.168/member_join2.php");
                comm.SetMessage("id=" + input_id.Text+"&name=" + input_name.Text +"&email="+input_email.Text);
                comm.Request();
                this.Close();
            }
            else
            {
                MessageBox.Show("등록양식이 완성되지 않았습니다!");
            }
         
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
