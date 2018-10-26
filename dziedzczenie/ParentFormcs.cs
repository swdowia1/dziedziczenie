using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dziedzczenie
{
    public partial class ParentFormcs : Form
    {
        public ParentFormcs()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ParentFormcs Cancel");
        }
        protected virtual void ResetSettings()
        {
            MessageBox.Show("Test");
            // Code logic in derived Form
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ParentFormcs ok");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }
    }
}
