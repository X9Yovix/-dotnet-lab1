namespace Exercice3
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
            TbN = new TextBox();
            labelRes = new Label();
            btnTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 168);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // TbN
            // 
            TbN.Location = new Point(149, 168);
            TbN.Name = "TbN";
            TbN.Size = new Size(421, 27);
            TbN.TabIndex = 1;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(141, 255);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(0, 20);
            labelRes.TabIndex = 2;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(627, 164);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(95, 35);
            btnTest.TabIndex = 3;
            btnTest.Text = "Tester";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTest);
            Controls.Add(labelRes);
            Controls.Add(TbN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbN;
        private Label labelRes;
        private Button btnTest;
    }
}
