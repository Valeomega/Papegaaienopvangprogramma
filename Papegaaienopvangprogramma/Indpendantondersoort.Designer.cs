namespace Papegaaienopvangprogramma
{
    partial class Indpendantondersoort
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
            this.comboBoxHoofdsoorten = new System.Windows.Forms.ComboBox();
            this.labelHOOFDSOORTEN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxHoofdsoorten
            // 
            this.comboBoxHoofdsoorten.FormattingEnabled = true;
            this.comboBoxHoofdsoorten.Location = new System.Drawing.Point(142, 12);
            this.comboBoxHoofdsoorten.Name = "comboBoxHoofdsoorten";
            this.comboBoxHoofdsoorten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHoofdsoorten.TabIndex = 0;
            // 
            // labelHOOFDSOORTEN
            // 
            this.labelHOOFDSOORTEN.AutoSize = true;
            this.labelHOOFDSOORTEN.Location = new System.Drawing.Point(12, 15);
            this.labelHOOFDSOORTEN.Name = "labelHOOFDSOORTEN";
            this.labelHOOFDSOORTEN.Size = new System.Drawing.Size(74, 13);
            this.labelHOOFDSOORTEN.TabIndex = 1;
            this.labelHOOFDSOORTEN.Text = "Hoofdsoorten:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ondersoortnaam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(197, 72);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonToevoegen.TabIndex = 4;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(106, 73);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 5;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // Indpendantondersoort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHOOFDSOORTEN);
            this.Controls.Add(this.comboBoxHoofdsoorten);
            this.Name = "Indpendantondersoort";
            this.Text = "Indpendantondersoort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHoofdsoorten;
        private System.Windows.Forms.Label labelHOOFDSOORTEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttoncancel;
    }
}