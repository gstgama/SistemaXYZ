using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class CadastroPessoas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Executar o codigo carregar pessoas, somente quando abrir a pagina pela primeira vez
            //ou seja, quando não for um PostBack

            if (!Page.IsPostBack)
            {
                CarregarPessoas();
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto do tipo Pessoa
            Pessoa objPessoa = new Pessoa();

            objPessoa.Nome = txtNome.Text;
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = rblSexo.SelectedValue;
            objPessoa.EstadoCivil = ddlEstadosCivis.SelectedValue;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;

            //Instanciar um objeto do PessoaDAL
            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            LimparCampos();

            lblMensagem.Text = "Pessoa inserida com sucesso.";

            CarregarPessoas();
        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Pegar o codigo que a pessoa deseja buscar.
            int codigo = Convert.ToInt32(txtCodigo.Text);

            PessoaDAL pDAL = new PessoaDAL();

            //Executar o metodo de seleção.
            Pessoa objPessoa = pDAL.SelecionarPessoaPeloCodigo(codigo);

            //Verificar se o objeto não esta nulo.
            if (objPessoa != null)
            {
                txtNome.Text = objPessoa.Nome;
                txtEmail.Text = objPessoa.Email;
                rblSexo.SelectedValue = objPessoa.Sexo;
                ddlEstadosCivis.SelectedValue = objPessoa.EstadoCivil;
                chkRecebeEmail.Checked = objPessoa.BtRecebeEmail;
                chkRecebeSMS.Checked = objPessoa.BtRecebeSMS;
            }
            else
            {
                LimparCampos();

                lblMensagem.Text = "Pessoa não encontrada";
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rblSexo.SelectedIndex = 0;
            ddlEstadosCivis.SelectedIndex = 0;
            chkRecebeEmail.Checked = false;
            chkRecebeSMS.Checked = false;

            lblMensagem.Text = string.Empty;
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
            objPessoa.Nome = txtNome.Text;
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = rblSexo.SelectedValue;
            objPessoa.EstadoCivil = ddlEstadosCivis.SelectedValue;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.AtualizarPessoa(objPessoa);

            LimparCampos();

            lblMensagem.Text = "Pessoa atualizada com sucesso.";

            CarregarPessoas();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegar o codigo a ser excluido
            int codigo = Convert.ToInt32(txtCodigo.Text);

            //Instanciar um objeto do PessoaDAL
            PessoaDAL pDAL = new PessoaDAL();

            //Executar o comando de exclusão, passando o codigo a ser excluido.
            pDAL.ExcluriPessoa(codigo);

            //Limpar os campos
            LimparCampos();

            //Escrever mensagem que foi excluido.
            lblMensagem.Text = "Pessoa Excluída com sucesso.";

            CarregarPessoas();
        }

        private void CarregarPessoas()
        {
            //Instanciar o objeto PessoaDAL
            PessoaDAL pDAL = new PessoaDAL();

            //Preencher o DataSource do GridView com uma Lista de Pessoas
            gvPessoas.DataSource = pDAL.ListarPessoas();

            //Precisamos mandar atualizar a tela
            gvPessoas.DataBind();
        }

    }
}