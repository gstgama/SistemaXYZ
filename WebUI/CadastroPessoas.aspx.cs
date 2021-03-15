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
        }
    }
}