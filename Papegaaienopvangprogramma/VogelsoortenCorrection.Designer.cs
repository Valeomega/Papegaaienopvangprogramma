namespace Papegaaienopvangprogramma
{
    partial class Vogelsoorteninfoaanpassen
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
            this.labelHoofdsoorten = new System.Windows.Forms.Label();
            this.labelOndersoorten = new System.Windows.Forms.Label();
            this.comboBoxHoofdsoorten = new System.Windows.Forms.ComboBox();
            this.buttonDoorvoeren = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxVogelondersoorten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelHoofdsoorten
            // 
            this.labelHoofdsoorten.AutoSize = true;
            this.labelHoofdsoorten.Location = new System.Drawing.Point(13, 13);
            this.labelHoofdsoorten.Name = "labelHoofdsoorten";
            this.labelHoofdsoorten.Size = new System.Drawing.Size(73, 13);
            this.labelHoofdsoorten.TabIndex = 1;
            this.labelHoofdsoorten.Text = "HoofdSoorten";
            // 
            // labelOndersoorten
            // 
            this.labelOndersoorten.AutoSize = true;
            this.labelOndersoorten.Location = new System.Drawing.Point(13, 59);
            this.labelOndersoorten.Name = "labelOndersoorten";
            this.labelOndersoorten.Size = new System.Drawing.Size(71, 13);
            this.labelOndersoorten.TabIndex = 2;
            this.labelOndersoorten.Text = "Ondersoorten";
            // 
            // comboBoxHoofdsoorten
            // 
            this.comboBoxHoofdsoorten.FormattingEnabled = true;
            this.comboBoxHoofdsoorten.Location = new System.Drawing.Point(92, 5);
            this.comboBoxHoofdsoorten.Name = "comboBoxHoofdsoorten";
            this.comboBoxHoofdsoorten.Size = new System.Drawing.Size(349, 21);
            this.comboBoxHoofdsoorten.TabIndex = 3;
            // 
            // buttonDoorvoeren
            // 
            this.buttonDoorvoeren.Location = new System.Drawing.Point(365, 293);
            this.buttonDoorvoeren.Name = "buttonDoorvoeren";
            this.buttonDoorvoeren.Size = new System.Drawing.Size(75, 23);
            this.buttonDoorvoeren.TabIndex = 5;
            this.buttonDoorvoeren.Text = "Wijzigen";
            this.buttonDoorvoeren.UseVisualStyleBackColor = true;
            this.buttonDoorvoeren.Click += new System.EventHandler(this.buttonDoorvoeren_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(284, 293);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listBoxVogelondersoorten
            // 
            this.listBoxVogelondersoorten.FormattingEnabled = true;
            this.listBoxVogelondersoorten.Location = new System.Drawing.Point(92, 59);
            this.listBoxVogelondersoorten.Name = "listBoxVogelondersoorten";
            this.listBoxVogelondersoorten.Size = new System.Drawing.Size(349, 225);
            this.listBoxVogelondersoorten.TabIndex = 7;
            // 
            // Vogelsoorteninfoaanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.Controls.Add(this.listBoxVogelondersoorten);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDoorvoeren);
            this.Controls.Add(this.comboBoxHoofdsoorten);
            this.Controls.Add(this.labelOndersoorten);
            this.Controls.Add(this.labelHoofdsoorten);
            this.Name = "Vogelsoorteninfoaanpassen";
            this.Text = "VogelSoorten info aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHoofdsoorten;
        private System.Windows.Forms.Label labelOndersoorten;
        private System.Windows.Forms.ComboBox comboBoxHoofdsoorten;
        private System.Windows.Forms.Button buttonDoorvoeren;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxVogelondersoorten;
    }
}