namespace Exercice6
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
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            btnLogin = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 94);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 217);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.Location = new Point(257, 91);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(286, 27);
            TbUsername.TabIndex = 2;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(257, 214);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(286, 27);
            TbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(337, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(257, 392);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelError);
            Controls.Add(btnLogin);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
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
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button btnLogin;
        private Label labelError;
    }
}
