namespace tugas_akhir_pbo
{
    partial class Form3
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            dgv1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(539, 397);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(414, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(160, 397);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgv1
            // 
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(66, 103);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(668, 275);
            dgv1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Black", 30F);
            label1.Location = new Point(326, 30);
            label1.Name = "label1";
            label1.Size = new Size(172, 70);
            label1.TabIndex = 12;
            label1.Text = "Form 3";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgv1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridView dgv1;
        private Label label1;
    }
}