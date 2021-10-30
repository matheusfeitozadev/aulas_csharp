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
    public partial class FormCustomerList : Form
    {
        private List<CustomerViewModel> customers;
        private EntityCustomer entityCustomer;
        public FormCustomerList()
        {
            InitializeComponent();

            entityCustomer = new EntityCustomer();

            ReturnInformationFromDatabase();
        }

        private void ReturnInformationFromDatabase()
        {
            customers = entityCustomer.List();

            FillListView(customers);
            FillGridView(customers);
        }

        private void FillListView(List<CustomerViewModel> list)
        {
            listViewCustomer.Items.Clear();

            var listViewItens = CustomerViewModel.FillListView(list);

            //listViewCustomer.Items.Add(new ListViewItem(new[] { "54", "Positivo", "True" }));
            //listViewCustomer.Items.Add(new ListViewItem(new[] { "54", "Samsung", "True" }));
            //listViewCustomer.Items.Add(new ListViewItem(new[] { "54", "JCH", "True" }));

            listViewCustomer.Items.AddRange(listViewItens);

            //Array -> Você cria o array especificando a quantidade total de itens ou você cria já com os itens
            //List -> você não se preocupa em quantas posicoes a lista tem

            //string[] nomes = new string[100];
            //string[] sobrenomes = new string[] { "" };

            //List<string> nomes_list = new List<string>();
            //nomes_list.Add("Joao");
            //nomes_list.Add("Wesley");

            //nomes_list.ToArray();
        }

        private void FillGridView(List<CustomerViewModel> list)
        {
            gridViewCustomer.Rows.Clear();

            foreach (var item in list)
            {
                gridViewCustomer.Rows.Add(new[] { item.Id.ToString(), item.CustomerName, item.Active.ToString() });
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomer.Text))
            {
                //Contains = LIKE
                var listTemp = customers.Where(x => 
                    x.CustomerName.ToUpper().Contains(txtCustomer.Text.ToUpper().Trim()) && x.Active == ckbActive.Checked).ToList();

                FillListView(listTemp);
                FillGridView(listTemp);
            }
            else
            {
                var listTemp = customers.Where(x =>
                    x.Active == ckbActive.Checked).ToList();

                FillListView(listTemp);
                FillGridView(listTemp);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillListView(customers);
            FillGridView(customers);

            txtCustomer.Clear();
            ckbActive.Checked = false;
        }

        private void gridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = gridViewCustomer.Rows[e.RowIndex];
                var id = int.Parse(row.Cells[0].Value.ToString());

                var customer = customers.Where(x => x.Id == id).FirstOrDefault();

                new FormCustomerEdit(customer).ShowDialog();
            }
            finally
            {
                ReturnInformationFromDatabase();
            }
           
        }
    }
}
