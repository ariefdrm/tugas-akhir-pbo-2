namespace tugas_akhir_pbo
{
    partial class CreateForm2
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Dgv1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(61, 235);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 185);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(206, 23);
            txtDescription.TabIndex = 18;
            // 
            // txtStocks
            // 
            txtStocks.Location = new Point(110, 137);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(206, 23);
            txtStocks.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(110, 87);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(206, 23);
            txtPrice.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 23);
            txtName.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 14;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 140);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 13;
            label3.Text = "Stocks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 12;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // Dgv1
            // 
            Dgv1.AllowUserToAddRows = false;
            Dgv1.AllowUserToDeleteRows = false;
            Dgv1.AllowUserToOrderColumns = true;
            Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            Dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(336, 12);
            Dgv1.Name = "Dgv1";
            Dgv1.Size = new Size(436, 426);
            Dgv1.TabIndex = 10;
            // 
            // CreateForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(txtStocks);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dgv1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateForm2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateForm2";
            Load += CreateForm2_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox txtDescription;
        private TextBox txtStocks;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView Dgv1;
    }
}