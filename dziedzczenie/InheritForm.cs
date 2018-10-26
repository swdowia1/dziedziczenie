using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dziedzczenie
{
    public partial class InheritForm : dziedzczenie.ParentFormcs
    {
        public InheritForm()
        {
            InitializeComponent();
        }


        protected override void ResetSettings()
        {
            base.ResetSettings();
            WriteImmediate("wywołanie dziceka");
            MessageBox.Show("z inherita");
            this.txtText.Text = DateTime.Now.ToString("HH mm:ss");

        }

    }
}
