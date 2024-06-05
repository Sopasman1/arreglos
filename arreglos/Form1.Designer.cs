namespace arreglos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            speciesbox = new ComboBox();
            Racetext = new TextBox();
            Nametext = new TextBox();
            savebtn = new Button();
            mascotalbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Species:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 123);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 1;
            label2.Text = "Race:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 214);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // speciesbox
            // 
            speciesbox.FormattingEnabled = true;
            speciesbox.Items.AddRange(new object[] { "Cat", "Dog" });
            speciesbox.Location = new Point(148, 46);
            speciesbox.Name = "speciesbox";
            speciesbox.Size = new Size(121, 23);
            speciesbox.TabIndex = 3;
            // 
            // Racetext
            // 
            Racetext.Location = new Point(148, 130);
            Racetext.Name = "Racetext";
            Racetext.Size = new Size(121, 23);
            Racetext.TabIndex = 4;
            // 
            // Nametext
            // 
            Nametext.Location = new Point(148, 221);
            Nametext.Name = "Nametext";
            Nametext.Size = new Size(121, 23);
            Nametext.TabIndex = 5;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(139, 292);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(130, 43);
            savebtn.TabIndex = 6;
            savebtn.Text = "save mascot";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // mascotalbl
            // 
            mascotalbl.AutoSize = true;
            mascotalbl.Location = new Point(12, 356);
            mascotalbl.Name = "mascotalbl";
            mascotalbl.Size = new Size(10, 15);
            mascotalbl.TabIndex = 7;
            mascotalbl.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 398);
            Controls.Add(mascotalbl);
            Controls.Add(savebtn);
            Controls.Add(Nametext);
            Controls.Add(Racetext);
            Controls.Add(speciesbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox speciesbox;
        private TextBox Racetext;
        private TextBox Nametext;
        private Button savebtn;
        private Label mascotalbl;
    }
}
