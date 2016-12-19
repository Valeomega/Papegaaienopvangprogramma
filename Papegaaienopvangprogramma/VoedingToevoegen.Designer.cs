namespace Papegaaienopvangprogramma
{
    partial class VoedingToevoegen
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
            this.labelVogelsoort = new System.Windows.Forms.Label();
            this.comboBoxVogelsoort = new System.Windows.Forms.ComboBox();
            this.tabControlVoeding = new System.Windows.Forms.TabControl();
            this.tabPageVoedinglijst = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonVoedseltoevoegen = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltijdbijvullen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVoedingNaam = new System.Windows.Forms.Label();
            this.listBoxVoedinglijst = new System.Windows.Forms.ListBox();
            this.weeklyRecurrenceControlETENbijvullen = new DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl();
            this.tabControlVoeding.SuspendLayout();
            this.tabPageVoedinglijst.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVogelsoort
            // 
            this.labelVogelsoort.AutoSize = true;
            this.labelVogelsoort.Location = new System.Drawing.Point(13, 13);
            this.labelVogelsoort.Name = "labelVogelsoort";
            this.labelVogelsoort.Size = new System.Drawing.Size(57, 13);
            this.labelVogelsoort.TabIndex = 0;
            this.labelVogelsoort.Text = "Vogelsoort";
            // 
            // comboBoxVogelsoort
            // 
            this.comboBoxVogelsoort.FormattingEnabled = true;
            this.comboBoxVogelsoort.Location = new System.Drawing.Point(76, 10);
            this.comboBoxVogelsoort.Name = "comboBoxVogelsoort";
            this.comboBoxVogelsoort.Size = new System.Drawing.Size(300, 21);
            this.comboBoxVogelsoort.TabIndex = 1;
            // 
            // tabControlVoeding
            // 
            this.tabControlVoeding.Controls.Add(this.tabPageVoedinglijst);
            this.tabControlVoeding.Controls.Add(this.tabPage2);
            this.tabControlVoeding.Location = new System.Drawing.Point(13, 70);
            this.tabControlVoeding.Name = "tabControlVoeding";
            this.tabControlVoeding.SelectedIndex = 0;
            this.tabControlVoeding.Size = new System.Drawing.Size(363, 242);
            this.tabControlVoeding.TabIndex = 2;
            // 
            // tabPageVoedinglijst
            // 
            this.tabPageVoedinglijst.Controls.Add(this.listBoxVoedinglijst);
            this.tabPageVoedinglijst.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoedinglijst.Name = "tabPageVoedinglijst";
            this.tabPageVoedinglijst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoedinglijst.Size = new System.Drawing.Size(355, 216);
            this.tabPageVoedinglijst.TabIndex = 0;
            this.tabPageVoedinglijst.Text = "Voedinglijst";
            this.tabPageVoedinglijst.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonVoedseltoevoegen);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.weeklyRecurrenceControlETENbijvullen);
            this.tabPage2.Controls.Add(this.labeltijdbijvullen);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.labelVoedingNaam);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toevoegen Voedsel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonVoedseltoevoegen
            // 
            this.buttonVoedseltoevoegen.Location = new System.Drawing.Point(274, 187);
            this.buttonVoedseltoevoegen.Name = "buttonVoedseltoevoegen";
            this.buttonVoedseltoevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonVoedseltoevoegen.TabIndex = 7;
            this.buttonVoedseltoevoegen.Text = "Toevoegen";
            this.buttonVoedseltoevoegen.UseVisualStyleBackColor = true;
            this.buttonVoedseltoevoegen.Click += new System.EventHandler(this.buttonVoedseltoevoegen_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aantal sheppen";
            // 
            // labeltijdbijvullen
            // 
            this.labeltijdbijvullen.AutoSize = true;
            this.labeltijdbijvullen.Location = new System.Drawing.Point(6, 31);
            this.labeltijdbijvullen.Name = "labeltijdbijvullen";
            this.labeltijdbijvullen.Size = new System.Drawing.Size(62, 13);
            this.labeltijdbijvullen.TabIndex = 2;
            this.labeltijdbijvullen.Text = "Tijdbijvullen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelVoedingNaam
            // 
            this.labelVoedingNaam.AutoSize = true;
            this.labelVoedingNaam.Location = new System.Drawing.Point(4, 4);
            this.labelVoedingNaam.Name = "labelVoedingNaam";
            this.labelVoedingNaam.Size = new System.Drawing.Size(78, 13);
            this.labelVoedingNaam.TabIndex = 0;
            this.labelVoedingNaam.Text = "Voeding naam:";
            // 
            // listBoxVoedinglijst
            // 
            this.listBoxVoedinglijst.FormattingEnabled = true;
            this.listBoxVoedinglijst.Location = new System.Drawing.Point(4, 4);
            this.listBoxVoedinglijst.Name = "listBoxVoedinglijst";
            this.listBoxVoedinglijst.Size = new System.Drawing.Size(348, 212);
            this.listBoxVoedinglijst.TabIndex = 0;
            // 
            // weeklyRecurrenceControlETENbijvullen
            // 
            this.weeklyRecurrenceControlETENbijvullen.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weeklyRecurrenceControlETENbijvullen.Appearance.Options.UseBackColor = true;
            this.weeklyRecurrenceControlETENbijvullen.Location = new System.Drawing.Point(9, 47);
            this.weeklyRecurrenceControlETENbijvullen.Name = "weeklyRecurrenceControlETENbijvullen";
            this.weeklyRecurrenceControlETENbijvullen.Size = new System.Drawing.Size(340, 96);
            this.weeklyRecurrenceControlETENbijvullen.TabIndex = 4;
            // 
            // VoedingToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 324);
            this.Controls.Add(this.tabControlVoeding);
            this.Controls.Add(this.comboBoxVogelsoort);
            this.Controls.Add(this.labelVogelsoort);
            this.Name = "VoedingToevoegen";
            this.Text = "VoedingToevoegen";
            this.tabControlVoeding.ResumeLayout(false);
            this.tabPageVoedinglijst.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVogelsoort;
        private System.Windows.Forms.ComboBox comboBoxVogelsoort;
        private System.Windows.Forms.TabControl tabControlVoeding;
        private System.Windows.Forms.TabPage tabPageVoedinglijst;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labeltijdbijvullen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVoedingNaam;
        private System.Windows.Forms.Button buttonVoedseltoevoegen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVoedinglijst;
        private DevExpress.XtraScheduler.UI.WeeklyRecurrenceControl weeklyRecurrenceControlETENbijvullen;
    }
}