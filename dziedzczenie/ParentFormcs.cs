using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            WriteImmediate("wywołanie rodzica");
            MessageBox.Show("Test");
            // Code logic in derived Form
        }
        protected virtual void WriteImmediate(params string[] list)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "->" + string.Join("", list));
        }

        private static void NewMethod()
        {
            Debug.WriteLine("wywolanie rodzica");
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
