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

namespace WinForms.Forms.Atividade3
{
    public partial class FormAtividade3 : Form
    {
        private List<AssemblyViewModel> assemblies;

        public FormAtividade3()
        {
            InitializeComponent();

            assemblies = new List<AssemblyViewModel>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var assembly = new AssemblyViewModel(txtAssemblyName.Text);

            if(!string.IsNullOrEmpty(assembly.AssemblyName))
            {
                var exist = CheckIfExistsInList(assembly);

                if(exist)
                {
                    assemblies.Add(assembly);
                    printList();

                    txtAssemblyName.Clear();
                    txtAssemblyName.Focus();
                    txtAssemblyName.SelectAll();
                }
                else
                {
                    MessageBox.Show("Assembly Name já adicionado!");
                }
            }
            else
            {
                MessageBox.Show("Campo em branco!");
            }
        }

        private bool CheckIfExistsInList(AssemblyViewModel assembly)
        {
            foreach(var item in assemblies)
            {
                if(item.AssemblyName.ToUpper().Equals(assembly.AssemblyName.ToUpper()))
                {
                    return false;
                }
            }

            return true;
        }

        private void printList()
        {
            listViewAssemblies.Items.Clear();

            foreach (var item in assemblies)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.AssemblyName;

                listViewAssemblies.Items.Add(listViewItem);
            }
        }
    }
}