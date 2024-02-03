namespace Exercice4
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
            btnCalc = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Factoriel = new DataGridViewTextBoxColumn();
            TbN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 81);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 159);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Factoriel";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(537, 79);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(80, 33);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "button1";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Factoriel });
            dataGridView1.Location = new Point(196, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 265);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Factoriel
            // 
            Factoriel.HeaderText = "Factoriel";
            Factoriel.MinimumWidth = 6;
            Factoriel.Name = "Factoriel";
            Factoriel.Width = 125;
            // 
            // TbN
            // 
            TbN.Location = new Point(196, 82);
            TbN.Name = "TbN";
            TbN.Size = new Size(297, 27);
            TbN.TabIndex = 4;
            TbN.TextChanged += TbN_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TbN);
            Controls.Add(dataGridView1);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCalc;
        private DataGridView dataGridView1;
        private TextBox TbN;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Factoriel;
    }
}
