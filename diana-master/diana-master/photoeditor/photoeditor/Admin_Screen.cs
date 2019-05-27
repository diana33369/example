using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoeditor
{
    public partial class Admin_Screen : Form
    {
        public Admin_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = new Users_Screen();
            users.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var logs = new Logs_Screen();
            logs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pictures = new Images_Screen();
            pictures.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen login_Screen = new Login_Screen();
            login_Screen.Show();
        }
    }
}
