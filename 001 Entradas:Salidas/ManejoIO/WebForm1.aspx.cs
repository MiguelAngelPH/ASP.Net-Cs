using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoIO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter ObjWriter = new StreamWriter(Server.MapPath(".") + "/Archivos/log.txt",true);
            ObjWriter.WriteLine("<b> Nombre y Apellido: " + TextBox1.Text + "</b> Legajo: " + TextBox2.Text + " Puesto: " + TextBox3.Text +
                " Sueldo: "+ TextBox4.Text + " Fecha: " + DateTime.Now.ToString());
            ObjWriter.WriteLine("<br/>");
            ObjWriter.WriteLine("<hr/>");

            ObjWriter.Close();

            lbValidacion.ForeColor = System.Drawing.Color.Green;
            lbValidacion.Text = "Datos Guardados en el Archivo";
        }
    }
}