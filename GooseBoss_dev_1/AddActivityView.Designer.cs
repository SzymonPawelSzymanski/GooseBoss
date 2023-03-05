namespace GooseBoss_dev_1
{
    partial class AddActivityView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_activityname = new System.Windows.Forms.Label();
            this.richTextBox_historydisplay = new System.Windows.Forms.RichTextBox();
            this.button_addnew = new System.Windows.Forms.Button();
            this.textBox_newact = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_activityname);
            this.panel1.Controls.Add(this.richTextBox_historydisplay);
            this.panel1.Controls.Add(this.button_addnew);
            this.panel1.Controls.Add(this.textBox_newact);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 350);
            this.panel1.TabIndex = 0;
            // 
            // label_activityname
            // 
            this.label_activityname.AutoSize = true;
            this.label_activityname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_activityname.Location = new System.Drawing.Point(0, 73);
            this.label_activityname.Name = "label_activityname";
            this.label_activityname.Size = new System.Drawing.Size(152, 21);
            this.label_activityname.TabIndex = 3;
            this.label_activityname.Text = "Name of the activity:";
            // 
            // richTextBox_historydisplay
            // 
            this.richTextBox_historydisplay.Enabled = false;
            this.richTextBox_historydisplay.Location = new System.Drawing.Point(3, 246);
            this.richTextBox_historydisplay.Name = "richTextBox_historydisplay";
            this.richTextBox_historydisplay.Size = new System.Drawing.Size(239, 96);
            this.richTextBox_historydisplay.TabIndex = 2;
            this.richTextBox_historydisplay.Text = "";
            // 
            // button_addnew
            // 
            this.button_addnew.AutoSize = true;
            this.button_addnew.Location = new System.Drawing.Point(4, 126);
            this.button_addnew.Name = "button_addnew";
            this.button_addnew.Size = new System.Drawing.Size(105, 25);
            this.button_addnew.TabIndex = 1;
            this.button_addnew.Text = "Add new activity";
            this.button_addnew.UseVisualStyleBackColor = true;
            this.button_addnew.Click += new System.EventHandler(this.button_addnew_Click);
            // 
            // textBox_newact
            // 
            this.textBox_newact.Location = new System.Drawing.Point(3, 97);
            this.textBox_newact.Name = "textBox_newact";
            this.textBox_newact.Size = new System.Drawing.Size(239, 23);
            this.textBox_newact.TabIndex = 0;
            // 
            // AddActivityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Name = "AddActivityView";
            this.Size = new System.Drawing.Size(251, 356);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label_activityname;
        public RichTextBox richTextBox_historydisplay;
        private Button button_addnew;
        private TextBox textBox_newact;
    }
}
