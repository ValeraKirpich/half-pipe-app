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
    public partial class FormBuyersList : Form
    {
        public FormBuyersList()
        {
            InitializeComponent();
        }

        private void FormBuyersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.database1DataSet2.Buyers);

        }
    }
}
