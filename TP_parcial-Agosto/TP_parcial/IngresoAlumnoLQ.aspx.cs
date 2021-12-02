using System;

namespace TP_parcial
{
    public partial class IngresoAlumnoLQ : System.Web.UI.Page
    {
        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                Alumno alumno = new Alumno()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = int.Parse(txtDni.Text),
                    email = txtEmail.Text,
                    turno = txtTurno.SelectedValue
                };

                dbContext.Alumnos.InsertOnSubmit(alumno);
                dbContext.SubmitChanges();
            }

            Response.Redirect("MostrarDatosLQ.aspx");
        }
    }
}