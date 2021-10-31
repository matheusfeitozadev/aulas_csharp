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
using WinForms.Classes.Assembly;
using WinForms.Classes.Entity;

namespace WinForms.Forms.AssemblyInsertion
{
    public partial class FormAssembly : Form
    {
        private EntityFactory entityFactory;
        private EntityCustomer entityCustomer;
        private EntityAssembly entityAssembly;
        private EntityProperty entityProperty;
        private EntityAssemblyProperties entityAssemblyProperties;
        private List<AssemblyPropertyViewModel> listProperties;

        public FormAssembly()
        {
            InitializeComponent();

            entityFactory = new EntityFactory();
            entityCustomer = new EntityCustomer();
            entityAssembly = new EntityAssembly();
            entityProperty = new EntityProperty();
            entityAssemblyProperties = new EntityAssemblyProperties();

            listProperties = new List<AssemblyPropertyViewModel>();

            AddListInCmbFactory(entityFactory.List());
            AddListInCmbCustomer(entityCustomer.List());
            AddListInCmbProperty(entityProperty.List());

            cmbCustomer.Enabled = false;
            EnableFieldsProperty(false);
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

            var fk_assembly = entityAssembly.Add(assemblyViewModel);

            listProperties.ForEach(x => x.FK_Assembly = fk_assembly);

            foreach (var item in listProperties)
            {
                entityAssemblyProperties.Add(item);
            }

            MessageBox.Show("Assembly adicionado!");
        }

        private void AddListInCmbFactory(List<FactoryViewModel> list)
        {
            cmbFactory.Items.Add(new ComboBoxItem("Selecione", 0));

            foreach (var item in list)
            {
                cmbFactory.Items.Add(new ComboBoxItem(item.Name, item.Id));
            }

            cmbFactory.SelectedIndex = 0;
        }

        private void AddListInCmbCustomer(List<CustomerViewModel> list)
        {
            cmbCustomer.Items.Add(new ComboBoxItem("Selecione", 0));

            foreach (var item in list)
            {
                cmbCustomer.Items.Add(new ComboBoxItem(item.CustomerName, item.Id));
            }

            cmbCustomer.SelectedIndex = 0;
        }

        private void AddListInCmbProperty(List<PropertyViewModel> list)
        {
            cmbProperty.Items.Add(new ComboBoxItem("Selecione", 0));

            foreach (var item in list)
            {
                cmbProperty.Items.Add(new ComboBoxItem(item.PropertyName, item.Id));
            }

            cmbProperty.SelectedIndex = 0;
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            var modelProperty = (ComboBoxItem) cmbProperty.SelectedItem;
            var propertyValue = txtPropertyValue.Text;

            if(!listProperties.Any(x=> x.FK_Property == modelProperty.Value))
            {
                var modelAssemblyProperty = new AssemblyPropertyViewModel()
                {
                    FK_Property = modelProperty.Value,
                    PropertyValue = propertyValue,
                    Property = new PropertyViewModel() { PropertyName = modelProperty.Text }
                };

                listProperties.Add(modelAssemblyProperty);

                AddInListProperties(modelAssemblyProperty);

                ClearFieldsProperty();
            }
            else
            {
                MessageBox.Show("Já existe uma propriedade na lista!");
            }
        }

        private void AddInListProperties(AssemblyPropertyViewModel modelProperty)
        {
            gridViewProperty.Rows.Add(new string[] { modelProperty.FK_Property.ToString(), modelProperty.Property.PropertyName, modelProperty.PropertyValue });
        }

        private void gridViewProperty_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void gridViewProperty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja remover essa propriedade?", "Atenção", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = gridViewProperty.Rows[e.RowIndex];
                var id = int.Parse(row.Cells[0].Value.ToString());

                var model = listProperties.FirstOrDefault(x => x.FK_Property == id);

                listProperties.Remove(model);

                gridViewProperty.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCustomer.Items.Count > 0)
            {
                int index = cmbCustomer.SelectedIndex;

                if (index > 0)
                {
                    EnableFieldsProperty(true);
                }
                else
                {
                    EnableFieldsProperty(false);
                }
            }
        }

        private void EnableFieldsProperty(bool active)
        {
            cmbProperty.Enabled = active;
            txtPropertyValue.Enabled = active;
            btnAddProperty.Enabled = active;

            if(!active)
            {
                ClearFieldsProperty();
            }
        }

        private void ClearFieldsProperty()
        {
            if (cmbProperty.Items.Count > 0)
            {
                cmbProperty.SelectedIndex = 0;
            }

            txtPropertyValue.Clear();
        }

        private void cmbFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbFactory.SelectedIndex;

            if(index > 0)
            {
                cmbCustomer.Enabled = true;
            }
            else
            {
                if(cmbCustomer.Items.Count > 0)
                    cmbCustomer.SelectedIndex = 0;

                cmbCustomer.Enabled = false;
            }
        }
    }
}
