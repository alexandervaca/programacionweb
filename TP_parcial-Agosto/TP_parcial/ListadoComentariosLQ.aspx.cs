using System;

namespace TP_parcial
{
    public partial class ListadoComentariosLQ : System.Web.UI.Page
    {
        private void CargarComentarios()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            gridViewComentarios.DataSource = dbContext.Comentarios;
            gridViewComentarios.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComentarios();
        }
    }
}