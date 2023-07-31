using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteAdmissao.Repository;

namespace TesteAdmissao // Replace with your actual namespace
{

    public partial class Default : Page
    {
        DB db = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = Session["Logged"];
           
            if (session == null)
            {
                Mensagem.Text = "Efetue login para continuar.";

            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {

            var user = db.Usuarios.Where(x => x.Usuario == txtUsername.Text && x.Senha == txtPassword.Text).FirstOrDefault();


            if (user != null)
            {
                Session["Logged"] = user;
                Response.Redirect("ListarPessoas.aspx");
            }
            else
            {
                Mensagem.Text = "Usuário ou senha incorretos";

                //Response.Redirect("default.aspx");
            }


        }


    }
}
