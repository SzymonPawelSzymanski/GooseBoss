namespace GooseBoss_dev_1
{
    public partial class Form1 : Form
    {
        string[] pageLabels = { "TO DO", "XML2LINE", "FrameCLR", "Add new activity"};

        public static ToDo_List actList = new ToDo_List();
        public Form1()
        {
            InitializeComponent();
            xmlToLineView1.Hide();
        }

        private void button_todo_Click(object sender, EventArgs e)
        {
            pageLabel.Text = pageLabels[0];
            actList.DisplayActList(toDoView1.panel1_todoview);
            xmlToLineView1.Hide();
            frameClrView1.Hide();
            toDoView1.Show();
            toDoView1.BringToFront();
        }

        private void button_xmltoline_Click(object sender, EventArgs e)
        {
            pageLabel.Text = pageLabels[1];
            toDoView1.Hide();
            frameClrView1.Hide();
            xmlToLineView1.Show();
            xmlToLineView1.BringToFront();
        }

        private void button_frameclr_Click(object sender, EventArgs e)
        {
            pageLabel.Text = pageLabels[2];
            toDoView1.Hide();
            xmlToLineView1.Hide();
            frameClrView1.Show();
            frameClrView1.BringToFront();
        }

        private void button_addactivity_Click(object sender, EventArgs e)
        {
            pageLabel.Text = pageLabels[3];
            toDoView1.Hide();
            frameClrView1.Hide();
            xmlToLineView1.Hide();
            addActivityView1.Show();
            addActivityView1.BringToFront();
        }
        private void pageLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}