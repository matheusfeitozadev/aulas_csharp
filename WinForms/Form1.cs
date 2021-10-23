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
using WinForms.Classes.Enum;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void CheckUser()
        {
            var user = new Usuario(txtLogin.Text, txtPassword.Text, chkLembrarSenha.Checked);

            var message = user.CheckUserAuth();

            if (string.IsNullOrEmpty(message))
            {
                setStatus("OK", LblStatusEnum.OK);
            }
            else
            {
                setStatus(message, LblStatusEnum.NOK);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

        private void setStatus(string message, LblStatusEnum lblStatusEnum)
        {
            lblStatus.Text = message;

            if(lblStatusEnum == LblStatusEnum.OK)
            {
                //verde
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                if(lblStatusEnum == LblStatusEnum.NOK)
                {
                    //vermelho
                    lblStatus.ForeColor = Color.Red;
                }
            }

            lblStatus.Refresh();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString().Equals("13"))
            {
                CheckUser();
            }
        }
    }
}
