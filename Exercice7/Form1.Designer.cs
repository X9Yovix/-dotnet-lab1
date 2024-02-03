namespace Exercice7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TbId = new TextBox();
            TbFirstName = new TextBox();
            TbLastName = new TextBox();
            TbAddress = new TextBox();
            CbGender = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 83);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Contact ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 126);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 284);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // TbId
            // 
            TbId.Location = new Point(94, 76);
            TbId.Name = "TbId";
            TbId.Size = new Size(148, 27);
            TbId.TabIndex = 5;
            // 
            // TbFirstName
            // 
            TbFirstName.Location = new Point(94, 119);
            TbFirstName.Name = "TbFirstName";
            TbFirstName.Size = new Size(150, 27);
            TbFirstName.TabIndex = 6;
            // 
            // TbLastName
            // 
            TbLastName.Location = new Point(94, 170);
            TbLastName.Name = "TbLastName";
            TbLastName.Size = new Size(148, 27);
            TbLastName.TabIndex = 7;
            // 
            // TbAddress
            // 
            TbAddress.Location = new Point(94, 223);
            TbAddress.Name = "TbAddress";
            TbAddress.Size = new Size(148, 27);
            TbAddress.TabIndex = 8;
            // 
            // CbGender
            // 
            CbGender.FormattingEnabled = true;
            CbGender.Location = new Point(94, 276);
            CbGender.Name = "CbGender";
            CbGender.Size = new Size(148, 28);
            CbGender.TabIndex = 9;
            CbGender.SelectedIndexChanged += CbGender_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(27, 321);
            button1.Name = "button1";
            button1.Size = new Size(82, 49);
            button1.TabIndex = 10;
            button1.Text = "Add Element";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(145, 321);
            button2.Name = "button2";
            button2.Size = new Size(82, 49);
            button2.TabIndex = 11;
            button2.Text = "Clear Form";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Location = new Point(27, 389);
            button3.Name = "button3";
            button3.Size = new Size(82, 49);
            button3.TabIndex = 12;
            button3.Text = "Clear Table";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Location = new Point(145, 389);
            button4.Name = "button4";
            button4.Size = new Size(82, 49);
            button4.TabIndex = 13;
            button4.Text = "Delete Line";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(485, 341);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 64);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(730, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 33);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CbGender);
            Controls.Add(TbAddress);
            Controls.Add(TbLastName);
            Controls.Add(TbFirstName);
            Controls.Add(TbId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TbId;
        private TextBox TbFirstName;
        private TextBox TbLastName;
        private TextBox TbAddress;
        private ComboBox CbGender;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
