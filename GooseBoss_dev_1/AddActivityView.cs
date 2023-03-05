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
    public partial class AddActivityView : UserControl
    {
        public AddActivityView()
        {
            InitializeComponent();
        }

        public void button_addnew_Click(object sender, EventArgs e)
        {
            Form1.actList.AddNewActivity(textBox_newact.Text, richTextBox_historydisplay);
            textBox_newact.Clear();
            richTextBox_historydisplay.SelectionStart = richTextBox_historydisplay.Text.Length;
            richTextBox_historydisplay.ScrollToCaret();
        }
    }
}
