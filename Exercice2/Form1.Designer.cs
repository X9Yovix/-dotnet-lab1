namespace Exercice2
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
            btnCalc = new Button();
            TbN1 = new TextBox();
            TbN2 = new TextBox();
            TbRes = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 163);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 255);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Resultat";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(333, 342);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(103, 38);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculer";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // TbN1
            // 
            TbN1.Location = new Point(226, 68);
            TbN1.Name = "TbN1";
            TbN1.Size = new Size(357, 27);
            TbN1.TabIndex = 4;
            // 
            // TbN2
            // 
            TbN2.Location = new Point(226, 163);
            TbN2.Name = "TbN2";
            TbN2.Size = new Size(357, 27);
            TbN2.TabIndex = 5;
            // 
            // TbRes
            // 
            TbRes.Location = new Point(226, 255);
            TbRes.Name = "TbRes";
            TbRes.Size = new Size(357, 27);
            TbRes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TbRes);
            Controls.Add(TbN2);
            Controls.Add(TbN1);
            Controls.Add(btnCalc);
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
        private Button btnCalc;
        private TextBox TbN1;
        private TextBox TbN2;
        private TextBox TbRes;
    }
}
