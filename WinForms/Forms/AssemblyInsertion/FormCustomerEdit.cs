using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Classes.Entity;

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormCustomerEdit : Form
    {
        private CustomerViewModel CustomerModel;
        private EntityCustomer entityCustomer;
        public FormCustomerEdit(CustomerViewModel customer)
        {
            InitializeComponent();

            entityCustomer = new EntityCustomer();

            CustomerModel = customer;

            FillInformation();
        }

        private void FillInformation()
        {
            txtCustomer.Text = CustomerModel.CustomerName;
            ckbActive.Checked = CustomerModel.Active;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerModel.CustomerName = txtCustomer.Text;
            CustomerModel.Active = ckbActive.Checked;

            entityCustomer.Update(CustomerModel);

            MessageBox.Show("Registro atualizado!");

            Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
