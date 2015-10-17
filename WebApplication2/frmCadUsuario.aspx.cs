using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication2
{
    public partial class frmCadUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.gravar(txtNomeusuario.Text, txtSenha.Text);
            limparComponentes();
        }

        private void limparComponentes()
        {
            txtNomeusuario.Text = "";
            txtSenha.Text = "";
        }
        
    }
}