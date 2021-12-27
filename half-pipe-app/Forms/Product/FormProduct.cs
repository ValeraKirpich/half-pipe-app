using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace half_pipe_app.Forms.Product
{
    public partial class FormProduct : Form
    {
        FormProductList ProductList;
        DataRow dataRow;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ProductList = (FormProductList)this.Owner;
            dataRow = ProductList.database1DataSet.Tables["Product"].NewRow();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataRow["Id"] = ProductList.dataGridView.RowCount + 1;
            dataRow["Наименование"] = textBox1.Text;

            ProductList.database1DataSet.Tables["Product"].Rows.Add(dataRow);
            ProductList.productTableAdapter .Update(ProductList.database1DataSet.Product);
            ProductList.database1DataSet.Tables["Product"].AcceptChanges();
            ProductList.dataGridView.Refresh();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
