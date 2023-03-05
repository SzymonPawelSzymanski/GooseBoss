using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseBoss_dev_1
{
    public class ToDo_List
    {
        List<ToDo_Activity> activities = new List<ToDo_Activity>();
        string[] defaults = { "Regresja GNR", "Regresja GRR", "Regresja SRF",
            "Raport SPR", "Raport GNR_B0", "Raport GNR-D", "Sprawdzone Pendingi", "MinkraftBoiSoMuch"};

        public void FillWithDefaults()
        {
            for (int i = 0; i < defaults.Count(); i++) 
            {
                ToDo_Activity act = new ToDo_Activity();
                act.name = defaults[i];
                activities.Add(act);
            }
        }

        public void AddNewActivity(string actName, RichTextBox richtextBox)
        {
            ToDo_Activity newAct = new ToDo_Activity();
            newAct.name = actName;
            activities.Add(newAct);
            richtextBox.Text += "Added activity: " + actName + "\n";
        }

        public void DisplayActList(Panel panel)
        {
            for(int i = 0; i < activities.Count(); i++)
            {
                CheckBox checkbox = new CheckBox();
                Label label = new Label();

                checkbox.Name = "checkbox_" + i;
                checkbox.Tag = "checkbox_" + i;
                checkbox.Text = activities[i].name;
                checkbox.AutoSize = true;
                checkbox.Font = new Font(checkbox.Font, FontStyle.Bold);
                checkbox.ForeColor = Color.Red;
                checkbox.Location = new System.Drawing.Point(10, 25 * i);
                checkbox.CheckedChanged += new EventHandler(CheckboxChecked);

                label.Text = "X";
                label.Font = new Font(checkbox.Font, FontStyle.Bold);
                label.ForeColor = Color.Red;


                panel.Controls.Add(checkbox);
            }
        }

        private void CheckboxChecked(object sender, EventArgs e)
        {
            CheckBox checkbox = (sender as CheckBox);
            if (checkbox.Checked)
            {
                checkbox.Font = new Font(checkbox.Font, FontStyle.Regular);
                checkbox.ForeColor = Color.Green;
            }
            else
            {
                checkbox.Font = new Font(checkbox.Font, FontStyle.Bold);
                checkbox.ForeColor = Color.Red;
            }
        }
    }
}
