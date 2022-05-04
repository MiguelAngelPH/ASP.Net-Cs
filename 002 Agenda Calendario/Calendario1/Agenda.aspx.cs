using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendario1
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;

            string fecha = Calendar1.SelectedDate.Day.ToString() +
                Calendar1.SelectedDate.Month.ToString() +
                Calendar1.SelectedDate.Year.ToString();

            StreamWriter ObjWriter = new StreamWriter(Server.MapPath(".") + "/Archivo/" + fecha + ".txt", true);
            ObjWriter.WriteLine("<b> Hora: " + TextBox1.Text + "<br/> </b> Titulo: " + TextBox2.Text + " Descripcion: " + TextBox3.Text +
                " Fecha: " + Calendar1.SelectedDate.ToString());
            ObjWriter.WriteLine("<br/>");
            ObjWriter.WriteLine("<hr/>");

            ObjWriter.Close();

            Lectura();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            Lectura();
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Lectura()
        {
            string selec1 = Calendar1.SelectedDate.Day.ToString() +
            Calendar1.SelectedDate.Month.ToString() +
            Calendar1.SelectedDate.Year.ToString();

            if (File.Exists(Server.MapPath(".") + "/Archivo/" + selec1 + ".txt"))
            {
                StreamReader leer = new StreamReader(Server.MapPath(".") + "/Archivo/" + selec1 + ".txt");
                Label1.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

    }
}