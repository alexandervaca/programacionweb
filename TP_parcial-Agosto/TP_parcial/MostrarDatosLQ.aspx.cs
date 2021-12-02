using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace TP_parcial
{
    public partial class MostrarDatosLQ : System.Web.UI.Page
    {
        private void CargarDatos()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            var alumno = dbContext.Alumnos.OrderByDescending(al => al.idAlumno).FirstOrDefault();
            List<Alumno> lista = new List<Alumno>();
            if (alumno != null)
            {
                lista.Add(alumno);
            }

            //gridViewAlumnos.DataSource = dbContext.Alumnos.OrderByDescending(al => al.idAlumno);//.FirstOrDefault();
            gridViewAlumnos.DataSource = lista;
            gridViewAlumnos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridViewRow row = gridViewAlumnos.Rows[0];
            int idAlumno = Convert.ToInt32(row.Cells[0].Text);

            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                Comentario nuevoComentario = new Comentario()
                {
                    comentario = txtComentarios.Text,
                    idAlumno = idAlumno
                };

                dbContext.Comentarios.InsertOnSubmit(nuevoComentario);
                dbContext.SubmitChanges();
            }

            Response.Redirect("IngresoAlumnoLQ.aspx");
        }
    }
}