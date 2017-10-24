using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4team_project
{
    public partial class res_hibernate : Form
    {
        public string execute;
        public res_hibernate()
        {
            InitializeComponent();
        }

        private void b_timeset_Click(object sender, EventArgs e)
        {
            if (time_hibernate.Text == null)
            {
                MessageBox.Show("시간이 입력되지 않았습니다!");
                execute = null;
            }
            else//시간이 입력되었다면
            {
                execute = time_hibernate.Text.ToString(); //예약시간
                MessageBox.Show(execute+"에 절전모드로 전환됩니다");
                this.Close(); //폼을 닫는다    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//폼을 닫는다
        }

        private void res_hibernate_Load(object sender, EventArgs e)
        {

        }
    }
}
