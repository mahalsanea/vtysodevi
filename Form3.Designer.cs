namespace vtysodevi
{
    partial class uygulama_raporu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ALL_CUSTOMERS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Exsit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ALL_CUSTOMERS
            // 
            this.ALL_CUSTOMERS.Location = new System.Drawing.Point(12, 26);
            this.ALL_CUSTOMERS.Name = "ALL_CUSTOMERS";
            this.ALL_CUSTOMERS.Size = new System.Drawing.Size(128, 23);
            this.ALL_CUSTOMERS.TabIndex = 1;
            this.ALL_CUSTOMERS.Text = "ALL CUSTOMERS";
            this.ALL_CUSTOMERS.UseVisualStyleBackColor = true;
            this.ALL_CUSTOMERS.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "CREDIT CARD PEYMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "PRODUCTS TOTAL SOLD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exsit_button
            // 
            this.Exsit_button.Location = new System.Drawing.Point(12, 315);
            this.Exsit_button.Name = "Exsit_button";
            this.Exsit_button.Size = new System.Drawing.Size(118, 36);
            this.Exsit_button.TabIndex = 4;
            this.Exsit_button.Text = "EXSIT";
            this.Exsit_button.UseVisualStyleBackColor = true;
            this.Exsit_button.Click += new System.EventHandler(this.Exsit_button_Click);
            // 
            // uygulama_raporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exsit_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ALL_CUSTOMERS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uygulama_raporu";
            this.Text = "uygulama_Raporu";
            this.Load += new System.EventHandler(this.uygulama_raporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ALL_CUSTOMERS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Exsit_button;
    }
}