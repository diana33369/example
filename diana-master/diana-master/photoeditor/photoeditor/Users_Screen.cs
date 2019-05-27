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
    public partial class Users_Screen : Form
    {
        public Users_Screen()
        {
            InitializeComponent();
            DBContext db = new DBContext();
            List<User> test_list = db.Users.ToList<User>();

            foreach (User user in test_list)
            {
                listBox1.Items.Add("Login: " + user.Login +
                    " "  + 
                    " Password :" + user.Password +
                    " "  +
                    " Email :" + user.Email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
