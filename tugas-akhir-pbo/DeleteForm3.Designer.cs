namespace tugas_akhir_pbo
{
    partial class DeleteForm3
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
            button1 = new Button();
            txtId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(408, 383);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(313, 383);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(291, 354);
            txtId.Name = "txtId";
            txtId.Size = new Size(217, 23);
            txtId.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 357);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "id";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 304);
            dataGridView1.TabIndex = 8;
            // 
            // DeleteForm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DeleteForm3";
            Text = "DeleteForm3";
            Load += DeleteForm3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button button1;
        private TextBox txtId;
        private Label label1;
        private DataGridView dataGridView1;
    }
}