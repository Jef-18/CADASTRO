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
    public partial class frmCliente : Form
    {


        public frmCliente()
        {
            InitializeComponent();
        }


        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            MessageBox.Show( txtNome.Text, "NOME: ");
            MessageBox.Show( mskCPF.Text, "CPF: ");
            MessageBox.Show(mskData.Text, "Data de Nascimento: ");
            MessageBox.Show(mskTel.Text, "Telefone: ");
            MessageBox.Show(txtEndereco.Text, "Endereço: ");

        }

        private void btnVoltarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
