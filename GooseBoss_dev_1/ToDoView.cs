using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GooseBoss_dev_1
{
    public partial class ToDoView : UserControl
    {
        public ToDoView()
        {
            InitializeComponent();
            Form1.actList.FillWithDefaults();
            Form1.actList.DisplayActList(panel1_todoview);
        }

        private void richTextBox1_todoview_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
