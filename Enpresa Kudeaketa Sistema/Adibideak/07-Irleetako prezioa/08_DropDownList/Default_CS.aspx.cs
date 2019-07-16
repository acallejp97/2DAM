using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default_CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
 this.Label1.Text = "El precio para " + this.DropDownList1.SelectedItem.Text + 
            " es de <b>" + this.DropDownList1.SelectedItem.Value + "</b> euros.";
    }
}