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
    public partial class FrameClrView : UserControl
    {
        List<char> frameCharList = new List<char>();
        public FrameClrView()
        {
            InitializeComponent();
        }

        private void button_convertFrame_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < richTextBox_insertFrame.TextLength; i++)
            {
                if (richTextBox_insertFrame.Text[i].Equals(":"))
                {
                    frameCharList.Append(" ");
                }
                frameCharList.Append(richTextBox_insertFrame.Text[i]);
            }
        }
    }
}
