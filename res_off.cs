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
    public partial class res_off : Form
    {
        public string execute;
        public res_off()
        {
            InitializeComponent();
        }

        private void res_off_Load(object sender, EventArgs e)
        {
            if (time_off.Text == null)
            {
                MessageBox.Show("시간이 입력되지 않았습니다!");
                execute = null;
            }
            else//시간이 입력되었다면
            {
                execute = time_off.Text.ToString(); //예약시간
                this.Close(); //폼을 닫는다    
            } 
            
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //폼을 닫는다
        }

        private void b_timeset_Click(object sender, EventArgs e)
        {

        }
    }
}
