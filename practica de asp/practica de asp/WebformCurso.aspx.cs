using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_de_asp
{
    public partial class Cursos : System.Web.UI.Page
    {
        private static int posi=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["posicion"] = "0";
                Session["nuevo"] = "0";

                using (Model1 tablas = new Model1())
                {
                    var curso = (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).First();
                    if (curso !=null)
                    {
                        
                        txtCod_cur.Text = curso.COD_CUR.ToString();
                        Txt_descrip.Text = curso.DESCRIPCION.ToString();
                        Txt_horas.Text = curso.HORAS.ToString();
                        Txt_tutor.Text = curso.TUTOR.ToString();
                        txtCod_cur.ReadOnly = true;
                    }
                }
            }
        }

        protected void btnPrimero_OnClick(object sender, EventArgs e)
        {
           primero();

        }

        public void primero()
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi = 0;
            using (Model1 tablas = new Model1())
            {
                try
                {
                    var curso = (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).Take(1).First();
                    if (curso != null)
                    {
                        txtCod_cur.Text = curso.COD_CUR.ToString();
                        Txt_descrip.Text = curso.DESCRIPCION.ToString();
                        Txt_horas.Text = curso.HORAS.ToString();
                        Txt_tutor.Text = curso.TUTOR.ToString();
                    }
                }
                catch (Exception exception)
                {
                    posi = 0;
                }
                Session["posicion"] = posi.ToString();
            }
        }

        protected void btnAnterior_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi--;
            using (Model1 tablas = new Model1())
            {
                try
                {
                    var curso = (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).First();
                    if (curso != null)
                    {
                        txtCod_cur.Text = curso.COD_CUR.ToString();
                        Txt_descrip.Text = curso.DESCRIPCION.ToString();
                        Txt_horas.Text = curso.HORAS.ToString();
                        Txt_tutor.Text = curso.TUTOR.ToString();
                    }
                }
                catch (Exception exception)
                {
                    posi++;
                }
                Session["posicion"] = posi.ToString();
            }


        }

        protected void btnSiguiente_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi++;
            using (Model1 tablas = new Model1())
            {
                try
                {
                    var curso = (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).First();
                    if (curso != null)
                    {
                        txtCod_cur.Text = curso.COD_CUR.ToString();
                        Txt_descrip.Text = curso.DESCRIPCION.ToString();
                        Txt_horas.Text = curso.HORAS.ToString();
                        Txt_tutor.Text = curso.TUTOR.ToString();
                    }
                }
                catch (Exception exception)
                {
                    posi--;
                }
                Session["posicion"] = posi.ToString();
            }
        
          
     
        }

        protected void btnUltimo_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            posi = 0;
            using (Model1 tablas = new Model1())
            {
                try
                {
                    posi = tablas.CURSOS.Count()-1;
                    var curso =
                        (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).Take(1).First();
                    if (curso != null)
                    {
                        txtCod_cur.Text = curso.COD_CUR.ToString();
                        Txt_descrip.Text = curso.DESCRIPCION.ToString();
                        Txt_horas.Text = curso.HORAS.ToString();
                        Txt_tutor.Text = curso.TUTOR.ToString();
                    }
                }
                catch (Exception exception)
                {
                    posi = tablas.CURSOS.Count()-1;
                }
                Session["posicion"] = posi.ToString();
            }

        }

        protected void btnModifica_OnClick(object sender, EventArgs e)
        {
            txtCod_cur.ReadOnly = true;
            int posi = Convert.ToInt32(Session["posicion"]);
            using (Model1 tablas = new Model1())
            {
                if (Session["nuevo"]=="0")
                {
                try
                {
                    var curso =
                        (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).First();
                    if (curso != null)
                    {
                        curso.COD_CUR = txtCod_cur.Text;
                        curso.DESCRIPCION = Txt_descrip.Text;
                        curso.HORAS = Convert.ToInt32(Txt_horas.Text);
                        curso.TUTOR = Txt_tutor.Text;
                        tablas.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    throw new Exception();
                }
                Session["posicion"] = posi.ToString();
                }
                else
                {
                  
                    CURSO cur = new CURSO();
                    cur.COD_CUR = txtCod_cur.Text;
                    cur.DESCRIPCION = Txt_descrip.Text;
                    cur.HORAS = Convert.ToInt32(Txt_horas.Text);
                    cur.TUTOR = Txt_tutor.Text;
                    tablas.CURSOS.Add(cur);
                    tablas.SaveChanges();

                }
            }

        }

        protected void btnBorra_OnClick(object sender, EventArgs e)
        {
            int posi = Convert.ToInt32(Session["posicion"]);
            string cur;
            using (Model1 tablas = new Model1())
            {
               
                    try
                    {
                        var curso =
                            (from p in tablas.CURSOS orderby p.COD_CUR ascending select p).Skip(posi).Take(1).First();

                        if (curso != null)
                        {
                            tablas.CURSOS.Remove(curso);
                            tablas.SaveChanges();
                            primero();
                        }
                    }
                    catch (Exception exception)
                    {
                        throw new Exception();
                    }
                
            }
        }

        protected void btnNuevo_OnClick(object sender, EventArgs e)
        {
            txtCod_cur.ReadOnly = false;
            txtCod_cur.Text = "";
            Txt_descrip.Text = "";
            Txt_horas.Text = "";
            Txt_tutor.Text = "";
            Session["nuevo"] = "1";

        }

        protected void btnCancelar_OnClick(object sender, EventArgs e)
        {
            primero();
        }
    }
}