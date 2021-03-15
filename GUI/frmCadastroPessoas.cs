using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroPessoas : Form
    {
        public frmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto do tipo pessoa e preencher com os valores da tela
            Pessoa objPessoa = new Pessoa();

            objPessoa.Nome = txtNome.Text;
            objPessoa.Email = txtEmail.Text;
            /*if (rbtnMasculino.Checked)
            {
                objPessoa.Sexo = "Masculino";
            }
            else
            {
                objPessoa.Sexo = "Feminino"; 
            }*/
            objPessoa.Sexo = rbtnMasculino.Checked ? "Masculino" : "Feminino";

            objPessoa.EstadoCivil = cbEstadosCivis.Text;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;

            //Instanciar um objeto do tipo PessoaDAL (acesso ao banco de dados)
            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            //Avisar o usuario que deu bom
            MessageBox.Show("Pessoa inserida com sucesso!");
        }
    }
}
