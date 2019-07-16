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
        
        for (int i = 1;i<=10;i++)
        {
            tabla += "<tr>";
        for (int k = 1;k<=10;k++)
        {
                tabla += "<td>" + i * k + "</td>";
        }
            tabla += "</tr>";
    }
        tabla += "</table>";
        Label1.Text = tabla;
    }
}