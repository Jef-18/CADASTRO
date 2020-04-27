using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmEmpresa : Form
    {


        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void lblRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(txtRazaoSocial.Text, "Razão Social: ");
            MessageBox.Show(mskCNPJ.Text, "CNPJ: ");
            MessageBox.Show(mskTel.Text, "Telefone: ");
            MessageBox.Show(txtEndereco.Text, "Endereço: ");


        }

        private void btnVoltarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
