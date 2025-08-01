namespace vtysodevi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.alsalman_DBDataSet = new vtysodevi.Alsalman_DBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new vtysodevi.Alsalman_DBDataSetTableAdapters.CustomersTableAdapter();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exsit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alsalman_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alsalman_DBDataSet
            // 
            this.alsalman_DBDataSet.DataSetName = "Alsalman_DBDataSet";
            this.alsalman_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.alsalman_DBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(33, 35);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(60, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(33, 58);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(244, 86);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 43);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(129, 86);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(93, 43);
            this.Clear_Button.TabIndex = 5;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exsit_Button
            // 
            this.Exsit_Button.Location = new System.Drawing.Point(36, 86);
            this.Exsit_Button.Name = "Exsit_Button";
            this.Exsit_Button.Size = new System.Drawing.Size(49, 43);
            this.Exsit_Button.TabIndex = 6;
            this.Exsit_Button.Text = "Exsit";
            this.Exsit_Button.UseVisualStyleBackColor = true;
            this.Exsit_Button.Click += new System.EventHandler(this.Exsit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 163);
            this.Controls.Add(this.Exsit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alsalman_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Alsalman_DBDataSet alsalman_DBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Alsalman_DBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exsit_Button;
    }
}

