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
    public partial class Images_Screen : Form
    {
        public Images_Screen()
        {
            InitializeComponent();
            List<img2.Image> test_list;
            using (DBContext db = new DBContext())
            {
                test_list = db.Images.ToList<img2.Image>();
            }
            foreach (img2.Image img in test_list)
            {
                listBox1.Items.Add("Author: " + img.Author +
                    " " +
                    " User: " + img.Create_date +
                    " Name: " + img.Name +
                    " Format " + img.Format
                    );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
