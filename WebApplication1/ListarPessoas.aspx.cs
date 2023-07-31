using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteAdmissao.Models;
using TesteAdmissao.Repository;

namespace TesteAdmissao
{
    public partial class Contact : Page
    {
        DB db = new DB();

        protected void Page_Load(object sender, EventArgs e)
        {
            var session = Session["Logged"];

            if (session == null)
            {
                Response.Redirect("Default.aspx");

            }

            if (!IsPostBack)
            {
                // Carregar os dados iniciais do GridView (por exemplo, da página 1)
                LoadGridViewData();
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridViewData();
        }

        private void LoadGridViewData()
        {
            // Aqui você deve obter os dados paginados do banco de dados ou de onde estiver armazenado
            DataTable dt = GetDataFromYourDataSource();

            // Carregar os dados paginados no GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        private DataTable GetDataFromYourDataSource()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Cep", typeof(string));
            dt.Columns.Add("Endereco", typeof(string));
            dt.Columns.Add("Pais", typeof(string));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));
            dt.Columns.Add("Nascimento", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Salario", typeof(decimal));

            var listaPessoas = db.Pessoas.ToList();
            var listaCargos = db.Cargos.ToList();
            var listaSalarios = db.Pessoa_Salarios.ToList();

            foreach (var pessoa in listaPessoas)
            {
                try
                {
                    DataRow newRow = dt.NewRow();
                    newRow["Nome"] = pessoa.Nome;
                    newRow["Cidade"] = pessoa.Cidade;
                    newRow["Email"] = pessoa.Email;
                    newRow["Cep"] = pessoa.CEP;
                    newRow["Endereco"] = pessoa.Endereco;
                    newRow["Pais"] = pessoa.Pais;
                    newRow["Usuario"] = pessoa.Usuario;
                    newRow["Telefone"] = pessoa.Telefone;
                    newRow["Nascimento"] = pessoa.Data_Nascimento;

                    var cargo = listaCargos.Where(x => x.ID == pessoa.Cargo_ID).FirstOrDefault();

                    if (cargo != null)
                    {
                        newRow["Cargo"] = cargo.Nome;
                    }
                    else
                    {
                        newRow["Cargo"] = "Não Informado";
                    }

                    var salario = listaSalarios.Where(x => x.Pessoa_ID == pessoa.ID).FirstOrDefault();

                    if (salario != null)
                    {
                        newRow["Salario"] = salario.Salario;
                    }
                    else
                    {
                        newRow["Salario"] = 0;
                    }

                    dt.Rows.Add(newRow);

                }
                catch (Exception ex)
                {

                }

            }

            return dt;
        }

        protected void recalcularSalario(object sender, EventArgs e)
        {

            var listaCargos = db.Cargos.ToList();
            var listaSalarios = db.Pessoa_Salarios.ToList();


            foreach (var item in listaSalarios)
            {
                var cargo = listaCargos.Where(x => x.Nome == item.Nome_Cargo).FirstOrDefault();
                //um dos registros (id 928) veio sem código cargo, para manter a integridade dos dados decidi não alterar sem permissão.
                if(cargo != null)
                {
                    TesteAdmissao.Functions.Calculo.fncCalculo(cargo.ID, item);

                    db.SaveChanges();
                
                }

            }

            Response.Redirect("ListarPessoas.aspx");

        }
    }
}