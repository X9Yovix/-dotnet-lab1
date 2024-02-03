namespace Exercice1
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
            TbFirstName = new TextBox();
            TbLastName = new TextBox();
            labelRes = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 96);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 181);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // TbFirstName
            // 
            TbFirstName.Location = new Point(245, 89);
            TbFirstName.Name = "TbFirstName";
            TbFirstName.Size = new Size(391, 27);
            TbFirstName.TabIndex = 2;
            TbFirstName.TextChanged += textBox1_TextChanged;
            // 
            // TbLastName
            // 
            TbLastName.Location = new Point(245, 178);
            TbLastName.Name = "TbLastName";
            TbLastName.Size = new Size(391, 27);
            TbLastName.TabIndex = 3;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(245, 347);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(0, 20);
            labelRes.TabIndex = 4;
            labelRes.Click += labelRes_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(373, 264);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 5;
            btnShow.Text = "Afficher";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(labelRes);
            Controls.Add(TbLastName);
            Controls.Add(TbFirstName);
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
        private TextBox TbFirstName;
        private TextBox TbLastName;
        private Label labelRes;
        private Button btnShow;
    }
}
