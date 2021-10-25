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
    public partial class FormCustomerList : Form
    {
        public FormCustomerList()
        {
            InitializeComponent();

            FillListView();
        }

        private void FillListView()
        {
            var listViewItens = Customer.FillListView(Customer.GetList());

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
    }
}
