using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace half_pipe_app.Forms.Buyers
{
    public partial class FormBuyer : Form
    {
        FormBuyersList FormList;
        DataRow dRow;

        public FormBuyer()
        {
            InitializeComponent();
        }

        private void FormBuyer_Load(object sender, EventArgs e)
        {
            FormList = (FormBuyersList)this.Owner;
            dRow = FormList.database1DataSet.Tables["Buyers"].NewRow();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dRow["Id"] = FormList.dataGridView.RowCount + 1;
            dRow["ФИО"] = textFIO.Text;

            FormList.database1DataSet.Tables["Buyers"].Rows.Add(dRow);
            FormList.buyersTableAdapter.Update(FormList.database1DataSet.Buyers);
            FormList.database1DataSet.Tables["Buyers"].AcceptChanges();
            FormList.dataGridView.Refresh();

            this.Close();
        }
    }
}
