namespace Exercice5
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
            TbN1 = new TextBox();
            TbN2 = new TextBox();
            TbRes = new TextBox();
            BtnCalc = new Button();
            RadioAddition = new RadioButton();
            RadioSoustraction = new RadioButton();
            RadioMulti = new RadioButton();
            RadioDivision = new RadioButton();
            groupBox1 = new GroupBox();
            BtnQuitter = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 56);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 129);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 90);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Resultat";
            // 
            // TbN1
            // 
            TbN1.Location = new Point(159, 53);
            TbN1.Name = "TbN1";
            TbN1.Size = new Size(243, 27);
            TbN1.TabIndex = 3;
            // 
            // TbN2
            // 
            TbN2.Location = new Point(159, 126);
            TbN2.Name = "TbN2";
            TbN2.Size = new Size(243, 27);
            TbN2.TabIndex = 4;
            // 
            // TbRes
            // 
            TbRes.Location = new Point(526, 87);
            TbRes.Name = "TbRes";
            TbRes.Size = new Size(243, 27);
            TbRes.TabIndex = 5;
            // 
            // BtnCalc
            // 
            BtnCalc.Location = new Point(526, 152);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(101, 45);
            BtnCalc.TabIndex = 6;
            BtnCalc.Text = "Calculer";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // RadioAddition
            // 
            RadioAddition.AutoSize = true;
            RadioAddition.Location = new Point(38, 24);
            RadioAddition.Name = "RadioAddition";
            RadioAddition.Size = new Size(88, 24);
            RadioAddition.TabIndex = 7;
            RadioAddition.TabStop = true;
            RadioAddition.Text = "Addition";
            RadioAddition.UseVisualStyleBackColor = true;
            // 
            // RadioSoustraction
            // 
            RadioSoustraction.AutoSize = true;
            RadioSoustraction.Location = new Point(213, 24);
            RadioSoustraction.Name = "RadioSoustraction";
            RadioSoustraction.Size = new Size(112, 24);
            RadioSoustraction.TabIndex = 8;
            RadioSoustraction.TabStop = true;
            RadioSoustraction.Text = "Soustraction";
            RadioSoustraction.UseVisualStyleBackColor = true;
            // 
            // RadioMulti
            // 
            RadioMulti.AutoSize = true;
            RadioMulti.Location = new Point(411, 24);
            RadioMulti.Name = "RadioMulti";
            RadioMulti.Size = new Size(122, 24);
            RadioMulti.TabIndex = 9;
            RadioMulti.TabStop = true;
            RadioMulti.Text = "Multiplication";
            RadioMulti.UseVisualStyleBackColor = true;
            // 
            // RadioDivision
            // 
            RadioDivision.AutoSize = true;
            RadioDivision.Location = new Point(575, 24);
            RadioDivision.Name = "RadioDivision";
            RadioDivision.Size = new Size(83, 24);
            RadioDivision.TabIndex = 10;
            RadioDivision.TabStop = true;
            RadioDivision.Text = "Division";
            RadioDivision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioDivision);
            groupBox1.Controls.Add(RadioMulti);
            groupBox1.Controls.Add(RadioSoustraction);
            groupBox1.Controls.Add(RadioAddition);
            groupBox1.Location = new Point(47, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 72);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(359, 364);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(101, 45);
            BtnQuitter.TabIndex = 12;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnQuitter);
            Controls.Add(groupBox1);
            Controls.Add(BtnCalc);
            Controls.Add(TbRes);
            Controls.Add(TbN2);
            Controls.Add(TbN1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TbN1;
        private TextBox TbN2;
        private TextBox TbRes;
        private Button BtnCalc;
        private RadioButton RadioAddition;
        private RadioButton RadioSoustraction;
        private RadioButton RadioMulti;
        private RadioButton RadioDivision;
        private GroupBox groupBox1;
        private Button BtnQuitter;
    }
}
