using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using half_pipe_app.Forms;

namespace half_pipe_app.Forms.Product
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.database1DataSet.Product);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form formEdit = new half_pipe_app.Forms.Product.FormProduct();

            formEdit.Owner = this;
            formEdit.Show();
        }
    }
}
