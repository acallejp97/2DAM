using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultCS : System.Web.UI.Page
{
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.Label1.Text = this.TextBox1.Text + " / " + this.TextBox2.Text;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int cifra1;
        cifra1 = Convert.ToInt32(this.TextBox1.Text);
        int cifra2;
        cifra2 = Convert.ToInt32(this.TextBox2.Text);
        int resultado;
        resultado = cifra1 + cifra2;
        this.Label1.Text = Convert.ToString(resultado);
    }
}