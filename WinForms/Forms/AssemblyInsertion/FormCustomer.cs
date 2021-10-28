using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Classes.Entity;

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormCustomer : Form
    {
        private List<CustomerViewModel> customers;
        private EntityCustomer entityCustomer;
        public FormCustomer()
        {
            InitializeComponent();

            entityCustomer = new EntityCustomer();

            customers = entityCustomer.List();

            ckbActive.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isOK = true;

            var customer = new CustomerViewModel(txtCustomer.Text.ToUpper(), true);

            var message = customer.CheckInformation();

            if(!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);

                isOK = false;
            }
            else
            {
                //verificar se o cliente já existe na lista
                var exists = customers.Where(x => x.CustomerName.ToUpper().Equals(customer.CustomerName)).FirstOrDefault();

                if(exists != null)
                {
                    MessageBox.Show("This Customer already exists!");
                    isOK = false;
                }
            }

            if(isOK)
            {
                //Enviar para o banco de dados...
                customers.Add(customer);

                ClearInformation();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInformation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearInformation()
        {
            txtCustomer.Clear();

            txtCustomer.Focus();
            txtCustomer.SelectAll();
        }


        private void LinkCSharp()
        {
            var obj = new CustomerViewModel();
            obj.Id = 54;
            obj.CustomerName = "POSITIVO";
            obj.Active = true;

            //1 - SqlConnection, SqlCommand -> SqlReader
            //2 - Entity Framework (Framework - Livre) -> Ele possibilita você fazer consultas nas tabelas utilizando o Link
            //3 - Microservices or MicroOrms -> Dapper

            //List All
            //select * from Customer
            var list = customers.ToList();

            //List All TOP 1
            //select top 1 * from Customer
            var firstCustomer = customers.ToList().FirstOrDefault();

            //List All TOP 1 where Customer = POSITIVO
            //select * from Customer where CustomerName = 'POSITIVO'
            var firstCustomerPositivo = customers.Where(x=> x.CustomerName.Equals("POSITIVO")).ToList().FirstOrDefault();

            //List All where Active = 1
            //select* from Customer where Active(bit) = 1 order by id
            var listAllActive = customers.Where(x => x.Active == true).OrderBy(x=> x.Id).ToList();

            //select* from Customer where Active(bit) = 1 order by id desc
            var listAllActiveDesc = customers.Where(x => x.Active == true).OrderByDescending(x => x.Id).ToList();

            //checar se existe o cliente positivo

            //1º forma
            //FirstOrDefault representa o TOP 1 do banco de dados
            var customerPositivo1 = customers.Where(x => x.CustomerName.Equals("EPSON")).FirstOrDefault();

            if(customerPositivo1 != null)
            {
                //existe
            }

            //2º Quantidade de registro da condição
            var quantidadeDeRegistros = customers.Where(x => x.CustomerName.Equals("EPSON")).ToList().Count;

            if(quantidadeDeRegistros > 0)
            {
                //existe
            }

            //3º Any(Algum) -> retorna uma variavel boolean
            var customerAnyPositivo = customers.Any(x => x.CustomerName.Equals("EPSON"));

            if(customerAnyPositivo == true)
            {
                //existe
            }

            //4º Contains - verifica todas as propriedades do objeto dentro da lista
            var contains = customers.Contains(obj);

            if(contains)
            {
                //existe
            }
        }
    }
}
