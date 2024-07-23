namespace tugas_akhir_pbo
{
    partial class Create
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtJob = new TextBox();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(436, 426);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 140);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 188);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 4;
            label4.Text = "Job";
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 23);
            txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(111, 87);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(111, 185);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(206, 23);
            txtJob.TabIndex = 8;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(77, 235);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtJob);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Create";
            Text = "Create";
            Load += Create_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtJob;
        private Button btnConfirm;
    }
}