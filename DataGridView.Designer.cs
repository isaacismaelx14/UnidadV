namespace UnidadV
{
    partial class DataGridView
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
            btnAdd = new Button();
            lblMonto = new Label();
            tbAmmount = new TextBox();
            label3 = new Label();
            cmbType = new ComboBox();
            label2 = new Label();
            tbAccountName = new TextBox();
            label1 = new Label();
            tbAccount = new TextBox();
            dgvDayli = new System.Windows.Forms.DataGridView();
            colAccount = new DataGridViewTextBoxColumn();
            colAccountName = new DataGridViewTextBoxColumn();
            colDebit = new DataGridViewTextBoxColumn();
            colCredit = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lblTotalDebit = new Label();
            totalPannel = new Panel();
            label5 = new Label();
            lblTotalCredit = new Label();
            inputPannel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDayli).BeginInit();
            totalPannel.SuspendLayout();
            inputPannel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(629, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMonto
            // 
            lblMonto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(523, 5);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 16;
            lblMonto.Text = "Monto";
            // 
            // tbAmmount
            // 
            tbAmmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbAmmount.Location = new Point(523, 23);
            tbAmmount.Name = "tbAmmount";
            tbAmmount.Size = new Size(100, 23);
            tbAmmount.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(427, 5);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(427, 23);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(90, 23);
            cmbType.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(93, 5);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre Cuenta";
            // 
            // tbAccountName
            // 
            tbAccountName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAccountName.Location = new Point(93, 23);
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(328, 23);
            tbAccountName.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // tbAccount
            // 
            tbAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbAccount.Location = new Point(5, 24);
            tbAccount.Name = "tbAccount";
            tbAccount.Size = new Size(84, 23);
            tbAccount.TabIndex = 9;
            // 
            // dgvDayli
            // 
            dgvDayli.AllowUserToAddRows = false;
            dgvDayli.AllowUserToOrderColumns = true;
            dgvDayli.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDayli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDayli.Columns.AddRange(new DataGridViewColumn[] { colAccount, colAccountName, colDebit, colCredit });
            dgvDayli.Location = new Point(52, 120);
            dgvDayli.Name = "dgvDayli";
            dgvDayli.ReadOnly = true;
            dgvDayli.RowTemplate.Height = 25;
            dgvDayli.Size = new Size(702, 280);
            dgvDayli.TabIndex = 18;
            dgvDayli.RowsAdded += dgvDayli_RowsAdded;
            dgvDayli.RowsRemoved += dgvDayli_RowsRemoved;
            // 
            // colAccount
            // 
            colAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colAccount.HeaderText = "Cuenta";
            colAccount.Name = "colAccount";
            colAccount.ReadOnly = true;
            colAccount.Width = 70;
            // 
            // colAccountName
            // 
            colAccountName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAccountName.HeaderText = "Nombre Cuenta";
            colAccountName.Name = "colAccountName";
            colAccountName.ReadOnly = true;
            // 
            // colDebit
            // 
            colDebit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDebit.HeaderText = "Débito";
            colDebit.Name = "colDebit";
            colDebit.ReadOnly = true;
            colDebit.Width = 67;
            // 
            // colCredit
            // 
            colCredit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCredit.HeaderText = "Crédito";
            colCredit.Name = "colCredit";
            colCredit.ReadOnly = true;
            colCredit.Width = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 19;
            label4.Text = "Total Débito:";
            // 
            // lblTotalDebit
            // 
            lblTotalDebit.AutoSize = true;
            lblTotalDebit.Location = new Point(83, 9);
            lblTotalDebit.Name = "lblTotalDebit";
            lblTotalDebit.Size = new Size(13, 15);
            lblTotalDebit.TabIndex = 20;
            lblTotalDebit.Text = "0";
            // 
            // totalPannel
            // 
            totalPannel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalPannel.Controls.Add(label5);
            totalPannel.Controls.Add(lblTotalCredit);
            totalPannel.Controls.Add(label4);
            totalPannel.Controls.Add(lblTotalDebit);
            totalPannel.Location = new Point(474, 406);
            totalPannel.Name = "totalPannel";
            totalPannel.Size = new Size(280, 32);
            totalPannel.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 9);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 21;
            label5.Text = "Total Crédito:";
            // 
            // lblTotalCredit
            // 
            lblTotalCredit.AutoSize = true;
            lblTotalCredit.Location = new Point(213, 9);
            lblTotalCredit.Name = "lblTotalCredit";
            lblTotalCredit.Size = new Size(13, 15);
            lblTotalCredit.TabIndex = 22;
            lblTotalCredit.Text = "0";
            // 
            // inputPannel
            // 
            inputPannel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPannel.Controls.Add(btnAdd);
            inputPannel.Controls.Add(tbAccount);
            inputPannel.Controls.Add(label1);
            inputPannel.Controls.Add(tbAccountName);
            inputPannel.Controls.Add(lblMonto);
            inputPannel.Controls.Add(label2);
            inputPannel.Controls.Add(tbAmmount);
            inputPannel.Controls.Add(cmbType);
            inputPannel.Controls.Add(label3);
            inputPannel.Location = new Point(47, 57);
            inputPannel.Name = "inputPannel";
            inputPannel.Size = new Size(707, 57);
            inputPannel.TabIndex = 22;
            // 
            // DataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(840, 462);
            Controls.Add(inputPannel);
            Controls.Add(totalPannel);
            Controls.Add(dgvDayli);
            MinimumSize = new Size(645, 469);
            Name = "DataGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dgvDayli).EndInit();
            totalPannel.ResumeLayout(false);
            totalPannel.PerformLayout();
            inputPannel.ResumeLayout(false);
            inputPannel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Label lblMonto;
        private TextBox tbAmmount;
        private Label label3;
        private ComboBox cmbType;
        private Label label2;
        private TextBox tbAccountName;
        private Label label1;
        private TextBox tbAccount;
        private System.Windows.Forms.DataGridView dgvDayli;
        private Label label4;
        private Label lblTotalDebit;
        private Panel totalPannel;
        private Panel inputPannel;
        private Label label5;
        private Label lblTotalCredit;
        private DataGridViewTextBoxColumn colAccount;
        private DataGridViewTextBoxColumn colAccountName;
        private DataGridViewTextBoxColumn colDebit;
        private DataGridViewTextBoxColumn colCredit;
    }
}