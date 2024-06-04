namespace uyg04.Forms
{
    partial class FrmPayment
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
            dgWork = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dgCustomer = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgPayment = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbWork = new Label();
            lbPayment = new Label();
            label4 = new Label();
            lbDiff = new Label();
            label5 = new Label();
            dtDate = new DateTimePicker();
            label3 = new Label();
            label7 = new Label();
            txtPaid = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // dgWork
            // 
            dgWork.AllowUserToAddRows = false;
            dgWork.AllowUserToDeleteRows = false;
            dgWork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWork.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn6, Column1, dataGridViewTextBoxColumn7 });
            dgWork.Location = new Point(501, 43);
            dgWork.Margin = new Padding(2);
            dgWork.Name = "dgWork";
            dgWork.ReadOnly = true;
            dgWork.RowHeadersWidth = 62;
            dgWork.RowTemplate.Height = 33;
            dgWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgWork.Size = new Size(488, 146);
            dgWork.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Kayıt No";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Başlık";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tarih";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Ücret";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dgCustomer.Location = new Point(15, 43);
            dgCustomer.Margin = new Padding(2);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(482, 296);
            dgCustomer.TabIndex = 57;
            dgCustomer.CellClick += dgCustomer_CellClick;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Müşteri No";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Satılan Ev";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.AllowUserToDeleteRows = false;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgPayment.Location = new Point(503, 193);
            dgPayment.Margin = new Padding(2);
            dgPayment.Name = "dgPayment";
            dgPayment.ReadOnly = true;
            dgPayment.RowHeadersWidth = 62;
            dgPayment.RowTemplate.Height = 33;
            dgPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPayment.Size = new Size(488, 146);
            dgPayment.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ödeme No";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Tarih";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Ödenen";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(202, 19);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 23);
            txtSearch.TabIndex = 60;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 61;
            label1.Text = "Aramak için bir değer giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 356);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 62;
            label2.Text = "Satılan EvToplam Ücretler";
            // 
            // lbWork
            // 
            lbWork.AutoSize = true;
            lbWork.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbWork.Location = new Point(260, 356);
            lbWork.Margin = new Padding(2, 0, 2, 0);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(49, 25);
            lbWork.TabIndex = 63;
            lbWork.Text = "0 TL";
            // 
            // lbPayment
            // 
            lbPayment.AutoSize = true;
            lbPayment.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbPayment.Location = new Point(603, 356);
            lbPayment.Margin = new Padding(2, 0, 2, 0);
            lbPayment.Name = "lbPayment";
            lbPayment.Size = new Size(49, 25);
            lbPayment.TabIndex = 65;
            lbPayment.Text = "0 TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(367, 356);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(227, 25);
            label4.TabIndex = 64;
            label4.Text = "Yapılan Toplam Ödemeler";
            // 
            // lbDiff
            // 
            lbDiff.AutoSize = true;
            lbDiff.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiff.Location = new Point(813, 356);
            lbDiff.Margin = new Padding(2, 0, 2, 0);
            lbDiff.Name = "lbDiff";
            lbDiff.Size = new Size(49, 25);
            lbDiff.TabIndex = 67;
            lbDiff.Text = "0 TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(751, 356);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 66;
            label5.Text = "Fark";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(443, 397);
            dtDate.Margin = new Padding(2);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(211, 23);
            dtDate.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 401);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 68;
            label3.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 424);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 72;
            label7.Text = "TL";
            // 
            // txtPaid
            // 
            txtPaid.Location = new Point(533, 421);
            txtPaid.Margin = new Padding(2);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(87, 23);
            txtPaid.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 424);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 70;
            label8.Text = "Ödeme";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(669, 397);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 42);
            btnSave.TabIndex = 73;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Müşteri No";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 446);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtPaid);
            Controls.Add(label8);
            Controls.Add(dtDate);
            Controls.Add(label3);
            Controls.Add(lbDiff);
            Controls.Add(label5);
            Controls.Add(lbPayment);
            Controls.Add(label4);
            Controls.Add(lbWork);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgPayment);
            Controls.Add(dgWork);
            Controls.Add(dgCustomer);
            Margin = new Padding(2);
            Name = "FrmPayment";
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgWork;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridView dgCustomer;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label lbWork;
        private Label lbPayment;
        private Label label4;
        private Label lbDiff;
        private Label label5;
        private DateTimePicker dtDate;
        private Label label3;
        private Label label7;
        private TextBox txtPaid;
        private Label label8;
        private Button btnSave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}