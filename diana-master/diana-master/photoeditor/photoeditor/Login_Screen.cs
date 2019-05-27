using photoeditor;
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
    public partial class Login_Screen : Form
    {

        DBContext db;

        public Login_Screen()
        {
            InitializeComponent();
            label1.Text = "Login";
            label2.Text = "Password";
            linkLabel1.Text = "Register";
            textBox2.PasswordChar = '*';
            button1.Text = "LOGIN";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg_form = new Register_Screen();
            reg_form.Show();
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (DBContext db = new DBContext())
            {

                List<User> test_list = db.Users.ToList<User>();

                foreach (User u in test_list)
                {

                    if (u.Login.Equals(textBox1.Text) && u.Password.Equals(textBox2.Text))
                    {
                        if (u.Admin == 0)
                        {
                            var editor = new Form1(u.Id);
                            editor.Show();
                            this.Hide();
                            db.Logs.Add(new Log()
                            {
                                Authorization = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"),
                                Username = u.Login,
                                User_id = u.Id
                            });
                            db.SaveChanges();
                            MessageBox.Show("You are logged!", "All ok",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (u.Admin == 1)
                        {
                            var admin = new Admin_Screen();
                            admin.Show();
                            this.Hide();
                            MessageBox.Show("You are logged as admin!", "All ok",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        break;
                    }
                }
                MessageBox.Show("Wrong Login or Password!", "Wrong data",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

    }
}

