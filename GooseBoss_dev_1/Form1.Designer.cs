namespace GooseBoss_dev_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageLabel = new System.Windows.Forms.Label();
            this.button_todo = new System.Windows.Forms.Button();
            this.button_xmltoline = new System.Windows.Forms.Button();
            this.button_frameclr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_addactivity = new System.Windows.Forms.Button();
            this.toDoView1 = new GooseBoss_dev_1.ToDoView();
            this.xmlToLineView1 = new GooseBoss_dev_1.XmlToLineView();
            this.frameClrView1 = new GooseBoss_dev_1.FrameClrView();
            this.addActivityView1 = new GooseBoss_dev_1.AddActivityView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageLabel.Location = new System.Drawing.Point(12, 9);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(79, 28);
            this.pageLabel.TabIndex = 0;
            this.pageLabel.Text = "TO DO:";
            this.pageLabel.Click += new System.EventHandler(this.pageLabel_Click);
            // 
            // button_todo
            // 
            this.button_todo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_todo.Location = new System.Drawing.Point(0, 3);
            this.button_todo.Name = "button_todo";
            this.button_todo.Size = new System.Drawing.Size(53, 23);
            this.button_todo.TabIndex = 1;
            this.button_todo.Text = "TO DO";
            this.button_todo.UseVisualStyleBackColor = true;
            this.button_todo.Click += new System.EventHandler(this.button_todo_Click);
            // 
            // button_xmltoline
            // 
            this.button_xmltoline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_xmltoline.Location = new System.Drawing.Point(59, 3);
            this.button_xmltoline.Name = "button_xmltoline";
            this.button_xmltoline.Size = new System.Drawing.Size(75, 23);
            this.button_xmltoline.TabIndex = 2;
            this.button_xmltoline.Text = "XML2LINE";
            this.button_xmltoline.UseVisualStyleBackColor = true;
            this.button_xmltoline.Click += new System.EventHandler(this.button_xmltoline_Click);
            // 
            // button_frameclr
            // 
            this.button_frameclr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_frameclr.Location = new System.Drawing.Point(134, 3);
            this.button_frameclr.Name = "button_frameclr";
            this.button_frameclr.Size = new System.Drawing.Size(75, 23);
            this.button_frameclr.TabIndex = 3;
            this.button_frameclr.Text = "FrameCLR";
            this.button_frameclr.UseVisualStyleBackColor = true;
            this.button_frameclr.Click += new System.EventHandler(this.button_frameclr_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_addactivity);
            this.panel1.Controls.Add(this.button_xmltoline);
            this.panel1.Controls.Add(this.button_frameclr);
            this.panel1.Controls.Add(this.button_todo);
            this.panel1.Location = new System.Drawing.Point(12, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 33);
            this.panel1.TabIndex = 4;
            // 
            // button_addactivity
            // 
            this.button_addactivity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addactivity.Location = new System.Drawing.Point(212, 3);
            this.button_addactivity.Name = "button_addactivity";
            this.button_addactivity.Size = new System.Drawing.Size(42, 23);
            this.button_addactivity.TabIndex = 4;
            this.button_addactivity.Text = "Add";
            this.button_addactivity.UseVisualStyleBackColor = true;
            this.button_addactivity.Click += new System.EventHandler(this.button_addactivity_Click);
            // 
            // toDoView1
            // 
            this.toDoView1.BackColor = System.Drawing.SystemColors.Info;
            this.toDoView1.Location = new System.Drawing.Point(12, 40);
            this.toDoView1.Name = "toDoView1";
            this.toDoView1.Size = new System.Drawing.Size(257, 362);
            this.toDoView1.TabIndex = 5;
            // 
            // xmlToLineView1
            // 
            this.xmlToLineView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xmlToLineView1.Location = new System.Drawing.Point(12, 40);
            this.xmlToLineView1.Name = "xmlToLineView1";
            this.xmlToLineView1.Size = new System.Drawing.Size(257, 362);
            this.xmlToLineView1.TabIndex = 6;
            // 
            // frameClrView1
            // 
            this.frameClrView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.frameClrView1.Location = new System.Drawing.Point(12, 40);
            this.frameClrView1.Name = "frameClrView1";
            this.frameClrView1.Size = new System.Drawing.Size(257, 362);
            this.frameClrView1.TabIndex = 7;
            // 
            // addActivityView1
            // 
            this.addActivityView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addActivityView1.Location = new System.Drawing.Point(12, 40);
            this.addActivityView1.Name = "addActivityView1";
            this.addActivityView1.Size = new System.Drawing.Size(257, 362);
            this.addActivityView1.TabIndex = 8;
            this.addActivityView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.toDoView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.addActivityView1);
            this.Controls.Add(this.frameClrView1);
            this.Controls.Add(this.xmlToLineView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pageLabel;
        private Button button_todo;
        private Button button_xmltoline;
        private Button button_frameclr;
        private Panel panel1;
        private ToDoView toDoView1;
        private XmlToLineView xmlToLineView1;
        private Button button_addactivity;
        private FrameClrView frameClrView1;
        private AddActivityView addActivityView1;
    }
}