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
using WinForms.Classes;
using WinForms.Classes.Entity;

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormAssembly : Form
    {
        private EntityFactory entityFactory;
        private EntityCustomer entityCustomer;
        private EntityAssembly entityAssembly;


        public FormAssembly()
        {
            InitializeComponent();

            entityFactory = new EntityFactory();
            entityCustomer = new EntityCustomer();
            entityAssembly = new EntityAssembly();

            AddListInCmbFactory(entityFactory.List());
            AddListInCmbCustomer(entityCustomer.List());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AssemblyViewModel assemblyViewModel = new AssemblyViewModel();
            assemblyViewModel.AssemblyName = txtAssemblyName.Text;
            assemblyViewModel.Active = ckbActive.Checked;

            var modelFactory = (ComboBoxItem) cmbFactory.SelectedItem;
            var modelCustomer = (ComboBoxItem)cmbCustomer.SelectedItem;

            assemblyViewModel.Factory = new FactoryViewModel(modelFactory.Value);
            assemblyViewModel.Customer = new CustomerViewModel(modelCustomer.Value);

            entityAssembly.Add(assemblyViewModel);

            MessageBox.Show("Assembly adicionado!");
        }

        private void AddListInCmbFactory(List<FactoryViewModel> list)
        {
            foreach(var item in list)
            {
                cmbFactory.Items.Add(new ComboBoxItem(item.Name, item.Id));
            }
            
        }

        private void AddListInCmbCustomer(List<CustomerViewModel> list)
        {
            foreach (var item in list)
            {
                cmbCustomer.Items.Add(new ComboBoxItem(item.CustomerName, item.Id));
            }
        }
    }
}
