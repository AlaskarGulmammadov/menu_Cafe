using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class cafeMoodcheck : Form
    {
        public cafeMoodcheck()
        {
            InitializeComponent();
        }

        private void cafeMoodcheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Qebul olundu.");
        }
    }
}
