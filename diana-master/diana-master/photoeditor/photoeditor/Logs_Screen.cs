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
    public partial class Logs_Screen : Form
    {
        public Logs_Screen()
        {
            InitializeComponent();
            List<Log> testList;
            using (DBContext db = new DBContext())
            {
                testList = db.Logs.ToList<Log>();
            }
            foreach (Log log in testList)
            {
                listBox1.Items.Add("Authotization: " + log.Authorization +
                    " " +
                    " User :" + log.Username);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
