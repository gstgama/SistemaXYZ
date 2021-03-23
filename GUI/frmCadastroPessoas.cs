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
            LimparCampos();
            CarregarPessoas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                PessoaDAL pDAL = new PessoaDAL();
                pDAL.ExcluriPessoa(codigo);

                MessageBox.Show("Pessoa excluida com sucesso!");

                //Metodo em uma linha.
                //new PessoaDAL().ExcluirPessoa(Convert.ToInt32(txtCodigo.Text));

                LimparCampos();
                CarregarPessoas();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
            objPessoa.Nome = txtNome.Text;
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = rbtnMasculino.Checked ? "Masculino" : "Feminino";
            objPessoa.EstadoCivil = cbEstadosCivis.Text;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.AtualizarPessoa(objPessoa);

            MessageBox.Show("Pessoa atualizada com sucesso.");

            LimparCampos();
            CarregarPessoas();
        }

        private void frmCadastroPessoas_Load(object sender, EventArgs e)
        {
            CarregarPessoas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Pegar o código a ser buscar
            //int codigo = Convert.ToInt32(txtCodigo.Text);
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {

                //Criar um objeto PessoaDAL
                PessoaDAL pDAL = new PessoaDAL();
                Pessoa objPessoa = pDAL.SelecionarPessoaPeloCodigo(codigo);

                //Verificar se o objPessoa esta nulo ou não.
                if (objPessoa != null)
                {
                    txtNome.Text = objPessoa.Nome;
                    txtEmail.Text = objPessoa.Email;
                    rbtnMasculino.Checked = objPessoa.Sexo == "Masculino";
                    rbtnFeminino.Checked = objPessoa.Sexo == "Feminino";
                    cbEstadosCivis.Text = objPessoa.EstadoCivil;
                    chkRecebeEmail.Checked = objPessoa.BtRecebeEmail;
                    chkRecebeSMS.Checked = objPessoa.BtRecebeSMS;
                }
                else
                {
                    MessageBox.Show("Esta pessoa não existe");
                    LimparCampos();
                }
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rbtnMasculino.Checked = true;
            rbtnFeminino.Checked = false;
            cbEstadosCivis.Text = string.Empty;
            chkRecebeEmail.Checked = false;
            chkRecebeSMS.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CarregarPessoas()
        {
            //Código para preencher o dataGridView com os dados da Lista

            //Instanciar o objeto PessoaDAL
            PessoaDAL pDAL = new PessoaDAL();

            //Preencher o Source do dataGridView
            dgvPessoas.DataSource = pDAL.ListarPessoas();
        }
    }
}
