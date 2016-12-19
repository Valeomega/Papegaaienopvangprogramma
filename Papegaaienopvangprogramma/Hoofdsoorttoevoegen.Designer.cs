namespace Papegaaienopvangprogramma
{
    partial class Hoofdsoorttoevoegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVSNAAM = new System.Windows.Forms.Label();
            this.Ondersoorten = new System.Windows.Forms.Label();
            this.textBoxVOGELSOORTNAAM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1naamondersoort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelVSNAAM
            // 
            this.labelVSNAAM.AutoSize = true;
            this.labelVSNAAM.Location = new System.Drawing.Point(10, 27);
            this.labelVSNAAM.Name = "labelVSNAAM";
            this.labelVSNAAM.Size = new System.Drawing.Size(88, 13);
            this.labelVSNAAM.TabIndex = 0;
            this.labelVSNAAM.Text = "Vogelsoort Naam";
            // 
            // Ondersoorten
            // 
            this.Ondersoorten.AutoSize = true;
            this.Ondersoorten.Location = new System.Drawing.Point(12, 51);
            this.Ondersoorten.Name = "Ondersoorten";
            this.Ondersoorten.Size = new System.Drawing.Size(71, 13);
            this.Ondersoorten.TabIndex = 1;
            this.Ondersoorten.Text = "Ondersoorten";
            // 
            // textBoxVOGELSOORTNAAM
            // 
            this.textBoxVOGELSOORTNAAM.Location = new System.Drawing.Point(144, 27);
            this.textBoxVOGELSOORTNAAM.Name = "textBoxVOGELSOORTNAAM";
            this.textBoxVOGELSOORTNAAM.Size = new System.Drawing.Size(284, 20);
            this.textBoxVOGELSOORTNAAM.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(326, 283);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonToevoegen.TabIndex = 5;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(245, 283);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 6;
            this.buttonCANCEL.Text = "Cancel";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 95);
            this.listBox1.TabIndex = 7;
            // 
            // textBox1naamondersoort
            // 
            this.textBox1naamondersoort.Location = new System.Drawing.Point(13, 180);
            this.textBox1naamondersoort.Name = "textBox1naamondersoort";
            this.textBox1naamondersoort.Size = new System.Drawing.Size(307, 20);
            this.textBox1naamondersoort.TabIndex = 8;
            // 
            // Hoofdsoorttoevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 318);
            this.Controls.Add(this.textBox1naamondersoort);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxVOGELSOORTNAAM);
            this.Controls.Add(this.Ondersoorten);
            this.Controls.Add(this.labelVSNAAM);
            this.Name = "Hoofdsoorttoevoegen";
            this.Text = "Vogelsoort Toevoegen";
            this.Controls.SetChildIndex(this.labelVSNAAM, 0);
            this.Controls.SetChildIndex(this.Ondersoorten, 0);
            this.Controls.SetChildIndex(this.textBoxVOGELSOORTNAAM, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.buttonToevoegen, 0);
            this.Controls.SetChildIndex(this.buttonCANCEL, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.textBox1naamondersoort, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVSNAAM;
        private System.Windows.Forms.Label Ondersoorten;
        private System.Windows.Forms.TextBox textBoxVOGELSOORTNAAM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1naamondersoort;
    }
}