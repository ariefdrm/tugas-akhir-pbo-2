namespace tugas_akhir_pbo
{
    partial class Fcreate3
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
            TxtCompany = new TextBox();
            TxtJob = new TextBox();
            TxtName = new TextBox();
            TxtAddress = new TextBox();
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
            btnConfirm.TabIndex = 29;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // TxtCompany
            // 
            TxtCompany.Location = new Point(107, 146);
            TxtCompany.Name = "TxtCompany";
            TxtCompany.Size = new Size(206, 23);
            TxtCompany.TabIndex = 28;
            // 
            // TxtJob
            // 
            TxtJob.Location = new Point(107, 98);
            TxtJob.Name = "TxtJob";
            TxtJob.Size = new Size(206, 23);
            TxtJob.TabIndex = 27;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(107, 48);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(206, 23);
            TxtName.TabIndex = 26;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(107, 192);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(206, 23);
            TxtAddress.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 149);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 24;
            label4.Text = "Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 23;
            label3.Text = "Job";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 51);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 195);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 21;
            label1.Text = "Address";
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
            Dgv1.TabIndex = 20;
            // 
            // Fcreate3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(TxtCompany);
            Controls.Add(TxtJob);
            Controls.Add(TxtName);
            Controls.Add(TxtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dgv1);
            Name = "Fcreate3";
            Text = "Fcreate3";
            Load += Fcreate3_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox TxtCompany;
        private TextBox TxtJob;
        private TextBox TxtName;
        private TextBox TxtAddress;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView Dgv1;
    }
}