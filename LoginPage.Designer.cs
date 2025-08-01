namespace vtysodevi
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EXIT_BOTTUN = new System.Windows.Forms.Button();
            this.Clear_Bottun = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // EXIT_BOTTUN
            // 
            this.EXIT_BOTTUN.Location = new System.Drawing.Point(7, 105);
            this.EXIT_BOTTUN.Name = "EXIT_BOTTUN";
            this.EXIT_BOTTUN.Size = new System.Drawing.Size(75, 23);
            this.EXIT_BOTTUN.TabIndex = 2;
            this.EXIT_BOTTUN.Text = "EXIT";
            this.EXIT_BOTTUN.UseVisualStyleBackColor = true;
            this.EXIT_BOTTUN.Click += new System.EventHandler(this.EXIT_BOTTUN_Click);
            // 
            // Clear_Bottun
            // 
            this.Clear_Bottun.Location = new System.Drawing.Point(88, 105);
            this.Clear_Bottun.Name = "Clear_Bottun";
            this.Clear_Bottun.Size = new System.Drawing.Size(90, 23);
            this.Clear_Bottun.TabIndex = 3;
            this.Clear_Bottun.Text = "Clear";
            this.Clear_Bottun.UseVisualStyleBackColor = true;
            this.Clear_Bottun.Click += new System.EventHandler(this.Clear_Bottun_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(184, 105);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 153);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear_Bottun);
            this.Controls.Add(this.EXIT_BOTTUN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EXIT_BOTTUN;
        private System.Windows.Forms.Button Clear_Bottun;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}