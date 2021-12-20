using half_pipe_app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace half_pipe_app
{
    public partial class mainForm : Form
    {
        private Form ActiveForm;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        // Процедура для открытия формы в текущей форме в панеле
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Сперва закроем текущую открытую форму
            if (ActiveForm != null)
                ActiveForm.Close();

            // Загоняем форму в текущую форму
            ActiveForm = childForm;
            ActiveForm.TopLevel = false;
            ActiveForm.FormBorderStyle = FormBorderStyle.None;
            ActiveForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(ActiveForm);
            this.panelDesktop.Tag = ActiveForm;
            ActiveForm.BringToFront();
            ActiveForm.Show();

            panelLabelText.Text = ActiveForm.Text;
        }

        private void buttonBuyers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Buyers.FormBuyersList(), sender);
        }
    }
}
