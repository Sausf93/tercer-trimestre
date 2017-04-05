using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_de_asp
{
    public partial class WebFormAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                GridView1.Visible = false;
                Session["posicion"] = "0";
                Session["nuevo"] = "0";

                using(Model1 tablas = new Model1())
                {

                    var curso = (from p in tablas.CURSOS
                                  select new {desc = p.DESCRIPCION, codcur = p.COD_CUR }).ToList();

                    foreach (var c in curso)
                    {
                        ListItem newitem = new ListItem(c.desc,c.codcur);
                        DropDownList1.Items.Add(newitem);
                        
                    }
                }
            }
        }


        protected void DropDownList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            using (Model1 tablas = new Model1())
            {
                var alumno = (from p in tablas.ALUMNOS
                              where p.COD_CUR == DropDownList1.SelectedValue.ToString()
                              select p).ToList();


                GridView1.DataSource = alumno;
                    GridView1.DataBind();

            }
        }


        protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            // WebFormModificaAlumno alumno = new WebFormModificaAlumno();
            int n = Convert.ToInt32(e.CommandArgument);
            Session["opcion"] = "J";
            Session["CODALU"] = GridView1.Rows[n].Cells[0].Text;
            if (e.CommandName=="M")
            {
                //Falta hacer que vaya o cree el formulario modificaAlumno.
                Session["opcion"] = "M";
                Response.Redirect("WebFormModificaAlumno.aspx");
            }
            if (e.CommandName =="B")
            {
                Session["opcion"] = "B";
                Response.Redirect("WebFormModificaAlumno.aspx");
            }
        }
    }
}