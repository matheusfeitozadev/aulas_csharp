using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Forms.Atividade3;

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FormCustomer();
            showForm(form);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAtividade3();
            showForm(form);
        }

        private void showForm(Form form)
        {
            form.TopLevel = false;

            panelMain.Controls.Add(form);
            form.Show();
        }
    }
}
