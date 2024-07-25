namespace tugas_akhir_pbo
{
    partial class EditForm2
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
            btnConfirm = new Button();
            txtDescription = new TextBox();
            txtStocks = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(59, 337);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 23;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(97, 290);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(183, 23);
            txtDescription.TabIndex = 22;
            // 
            // txtStocks
            // 
            txtStocks.Location = new Point(97, 244);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(183, 23);
            txtStocks.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(97, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 23);
            txtPrice.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 143);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(97, 92);
            txtId.Name = "txtId";
            txtId.Size = new Size(183, 23);
            txtId.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 293);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 17;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 247);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Stocks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 197);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 15;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 146);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 95);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 13;
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
            dataGridView1.TabIndex = 12;
            // 
            // EditForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(txtStocks);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditForm2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditForm2";
            Load += EditForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox txtDescription;
        private TextBox txtStocks;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}