using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLABA28
{
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }

        public void Navigate(Form from, Form to)
        {
            from.Hide();
            to.ShowDialog();
            from.Show();
        }
    }
}
