using UnidadV.Objects;

namespace UnidadV
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            Types types = new();
            InitializeComponent();
            cmbType.DataSource = types.TypesList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cmbType.Text;
            if (!GetValidate()) return;

            AddToTable(type);
            Clear();
        }

        bool GetValidate()
        {
            if (tbAccount.Text == string.Empty)
            {
                ThrowError("Debe ingresar una cuenta");
                tbAccount.Focus();
                return false;
            }

            if (tbAccountName.Text == string.Empty)
            {
                ThrowError("Debe ingresar un nombre de cuenta");
                tbAccountName.Focus();
                return false;
            }

            if (cmbType.Text == Types.Select)
            {
                ThrowError("Debe seleccionar el tipo de transacción");
                cmbType.Focus();
                return false;
            }

            if (tbAmmount.Text == string.Empty)
            {
                ThrowError("Debe ingresar un monto");
                tbAmmount.Focus();
                return false;
            }

            return true;
        }

        void ThrowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void AddToTable(string type)
        {
            string account = tbAccount.Text;
            string accountName = tbAccountName.Text;
            double ammount = double.Parse(tbAmmount.Text);

            if (type == Types.Credit) dgvDayli.Rows.Add(account, accountName, null, ammount.ToString("0.00"));
            if (type == Types.Debit) dgvDayli.Rows.Add(account, accountName, ammount.ToString("0.00"), null);
        }

        double GetFromTable(int index, int cell)
        {
            object cellValue = dgvDayli.Rows[index].Cells[cell].Value;

            if (cellValue == null) return 0;

            double.TryParse(cellValue.ToString(), out double value);
            return value;
        }

        void CalcTotal()
        {
            double creditTotal = 0;
            double debitTotal = 0;

            for (int i = 0; i < dgvDayli.Rows.Count; i++)
            {
                double creditValue = GetFromTable(i, 3);
                double debitValue = GetFromTable(i, 2);

                creditTotal += creditValue;
                debitTotal += debitValue;
            }

            lblTotalCredit.Text = creditTotal.ToString("0.00");
            lblTotalDebit.Text = debitTotal.ToString("0.00");
        }

        void Clear()
        {
            tbAccount.Text = string.Empty;
            tbAccountName.Text = string.Empty;
            tbAmmount.Text = string.Empty;
            cmbType.SelectedIndex = 0;
        }

        private void dgvDayli_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcTotal();
        }

        private void dgvDayli_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcTotal();
        }
    }
}
