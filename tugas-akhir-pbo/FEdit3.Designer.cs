namespace tugas_akhir_pbo
{
    partial class FEdit3
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
            txtId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtCompany = new TextBox();
            txtJob = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(97, 92);
            txtId.Name = "txtId";
            txtId.Size = new Size(206, 23);
            txtId.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 95);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 24;
            label1.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(397, 426);
            dataGridView1.TabIndex = 23;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(97, 242);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(206, 23);
            txtCompany.TabIndex = 37;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(97, 194);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(206, 23);
            txtJob.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 23);
            txtName.TabIndex = 35;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(97, 288);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 23);
            txtAddress.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 245);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 33;
            label4.Text = "Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 197);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 32;
            label3.Text = "Job";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 31;
            label2.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 291);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 30;
            label5.Text = "Address";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(65, 332);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 38;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FEdit3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtCompany);
            Controls.Add(txtJob);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FEdit3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FEdit3";
            Load += FEdit3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtCompany;
        private TextBox txtJob;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnConfirm;
    }
}