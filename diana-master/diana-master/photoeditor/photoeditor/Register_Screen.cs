using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoeditor
{

    public partial class Register_Screen : Form
    {

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public Register_Screen()
        {
            InitializeComponent();
            label1.Text = "Login";
            label2.Text = "Password";
            label3.Text = "Repeat password";
            label4.Text = "Email";

            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';

            button1.Text = "REGISTER";
        }

        private bool Validation()
        {
            bool validator = true;

            Utilities ut = new Utilities();

            if (textBox1.Text.Length == 0 ||
                textBox2.Text.Length == 0 ||
                textBox3.Text.Length == 0 ||
                textBox4.Text.Length == 0)
            {
                MessageBox.Show("You should fill all fields", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ut.IsValidEmail(textBox4.Text) == false)
            {
                MessageBox.Show("Email is invalid", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validator = false;
            }

            if (ut.IsValidPassword(textBox2.Text) == false)
            {
                MessageBox.Show("Password is invalid", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validator = false;
            }

            if (!textBox2.Text.Equals(textBox3.Text))
            {
                MessageBox.Show("Passwords not eq", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validator = false;
            }

            return validator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                using (DBContext db = new DBContext())
                {
                    try
                    {

                        db.Users.Add(new User()
                        {
                            Email = textBox4.Text,
                            Login = textBox1.Text,
                            Password = textBox2.Text,
                            Admin = 0
                        });

                        db.SaveChanges();

                        MessageBox.Show("You are registered!", "All ok",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Can' register user with this data", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
