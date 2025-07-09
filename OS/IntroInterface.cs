using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class IntroInterface : Form
    {
        public IntroInterface()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide(); // Ẩn form hiện tại
            f.Show();
        }
    }
}
