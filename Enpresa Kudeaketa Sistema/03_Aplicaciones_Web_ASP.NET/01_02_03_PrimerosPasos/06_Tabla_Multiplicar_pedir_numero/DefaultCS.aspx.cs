using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultCS : System.Web.UI.Page
{
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        String tabla = "<table border='1'>";
        int k;

        k =Int32.Parse(TextBox1.Text);
        
        for (int i = 1;i<=10;i++)
        {
            tabla += "<tr>";

            tabla += "<td>" + i + " * " + k + " = " + "</td>";
            tabla += "<td>" + i * k + "</td>";

            tabla += "</tr>";
    }
        tabla += "</table>";
        Label1.Text = tabla;
    }
}