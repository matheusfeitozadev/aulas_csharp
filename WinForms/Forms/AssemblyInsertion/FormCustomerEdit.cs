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

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormCustomerEdit : Form
    {
        private CustomerViewModel Customer;
        public FormCustomerEdit(CustomerViewModel customer)
        {
            InitializeComponent();

            Customer = customer;

            FillInformation();
        }

        private void FillInformation()
        {
            txtCustomer.Text = Customer.CustomerName;
            ckbActive.Checked = Customer.Active;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customers = new List<CustomerViewModel>();
            var customer = customers.Where(x => x.Id == Customer.Id).FirstOrDefault();

            customer.CustomerName = txtCustomer.Text;
            customer.Active = ckbActive.Checked;

            //commit

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
