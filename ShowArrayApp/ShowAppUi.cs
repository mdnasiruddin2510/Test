using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowArrayApp
{
    public partial class showApp : Form
    {
        public showApp()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] names = new string[5];
        private void ShowButton_Click(object sender, EventArgs e)
        {
            names[i] = Convert.ToString(NameTextBox.Text);
            MessageBox.Show(names[i]);
            i++;
        }
    }
}
