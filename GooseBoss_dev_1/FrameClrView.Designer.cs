namespace GooseBoss_dev_1
{
    partial class FrameClrView
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
            this.richTextBox_insertFrame = new System.Windows.Forms.RichTextBox();
            this.richTextBox_processedFrame = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_convertFrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_insertFrame
            // 
            this.richTextBox_insertFrame.Location = new System.Drawing.Point(14, 46);
            this.richTextBox_insertFrame.Name = "richTextBox_insertFrame";
            this.richTextBox_insertFrame.Size = new System.Drawing.Size(225, 113);
            this.richTextBox_insertFrame.TabIndex = 0;
            this.richTextBox_insertFrame.Text = "";
            // 
            // richTextBox_processedFrame
            // 
            this.richTextBox_processedFrame.Location = new System.Drawing.Point(14, 210);
            this.richTextBox_processedFrame.Name = "richTextBox_processedFrame";
            this.richTextBox_processedFrame.Size = new System.Drawing.Size(225, 113);
            this.richTextBox_processedFrame.TabIndex = 1;
            this.richTextBox_processedFrame.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konwerter ramek";
            // 
            // button_convertFrame
            // 
            this.button_convertFrame.Location = new System.Drawing.Point(65, 165);
            this.button_convertFrame.Name = "button_convertFrame";
            this.button_convertFrame.Size = new System.Drawing.Size(131, 23);
            this.button_convertFrame.TabIndex = 3;
            this.button_convertFrame.Text = "Zamień \":\" na spację";
            this.button_convertFrame.UseVisualStyleBackColor = true;
            this.button_convertFrame.Click += new System.EventHandler(this.button_convertFrame_Click);
            // 
            // FrameClrView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.button_convertFrame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_processedFrame);
            this.Controls.Add(this.richTextBox_insertFrame);
            this.Name = "FrameClrView";
            this.Size = new System.Drawing.Size(251, 356);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox_insertFrame;
        private RichTextBox richTextBox_processedFrame;
        private Label label1;
        private Button button_convertFrame;
    }
}
