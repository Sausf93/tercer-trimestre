using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_de_asp
{
    public partial class WebFormModificaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string alu;
            alu = Session["CODALU"].ToString();


            using (Model1 tablas = new Model1())
            {
                var alumno = (from p in tablas.ALUMNOS
                    where p.COD_ALU == alu
                    select p).First();



                if (Session["opcion"].ToString() == "M")
                {
                    TextBoxCur.Text = alumno.COD_CUR;
                    TextBoxNom.Text = alumno.NOMBRE;
                    TextBoxAlu.Text = alumno.COD_ALU;
                    TextBoxDNI.Text = alumno.DNI;
                    TexboxApe.Text = alumno.APELLIDOS;
                    TextBoxAlu.Enabled = false;
                    TextBoxCur.Enabled = false;

                }
                if (Session["opcion"].ToString() == "B")
                {
                    TextBoxCur.Text = alumno.COD_CUR;
                    TextBoxNom.Text = alumno.NOMBRE;
                    TextBoxAlu.Text = alumno.COD_ALU;
                    TextBoxDNI.Text = alumno.DNI;
                    TexboxApe.Text = alumno.APELLIDOS;
                    TextBoxCur.Enabled = false;
                    TextBoxNom.Enabled = false;
                    TextBoxAlu.Enabled = false;
                    TextBoxDNI.Enabled = false;
                    TexboxApe.Enabled = false;

                }
            }
        }

        protected void Aceptar_OnClick(object sender, EventArgs e)
        {

            if (Session["opcion"].ToString()=="M")
            {
                string alu;
                alu = Session["CODALU"].ToString();
                using (Model1 tablas = new Model1())
                {
                    var alumno = (from p in tablas.ALUMNOS
                                  where p.COD_ALU == alu
                                  select p).First();

                    alumno.COD_CUR = TextBoxCur.Text;
                    alumno.NOMBRE = TextBoxNom.Text;
                    alumno.COD_ALU = TextBoxAlu.Text;
                    alumno.DNI = TextBoxDNI.Text;
                    alumno.APELLIDOS = TexboxApe.Text;
                    tablas.SaveChanges();
                } 
                Response.Redirect("WebFormAlumnos.aspx");
            }
            if (Session["opcion"].ToString() == "B")
            {
                string alu;
                alu = Session["CODALU"].ToString();
                using (Model1 tablas = new Model1())
                {
                    var alumno = (from p in tablas.ALUMNOS
                                  where p.COD_ALU == alu
                                  select p).First();

                    tablas.ALUMNOS.Remove(alumno);
                    tablas.SaveChanges();
                }
                Response.Redirect("WebFormAlumnos.aspx");
            }
        }

        protected void Cancelar_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("WebFormAlumnos.aspx");
        }
    }
}