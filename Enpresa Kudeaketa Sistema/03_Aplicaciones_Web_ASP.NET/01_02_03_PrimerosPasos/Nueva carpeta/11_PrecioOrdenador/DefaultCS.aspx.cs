using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultCS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Double suma = 0;
        suma = Convert.ToDouble(this.DropDownList1.SelectedItem.Value);
        foreach(ListItem item in this.CheckBoxList1.Items)
        {
            if (item.Selected)
            {
                suma += Convert.ToDouble(item.Value);
            }
        }
        this.lblResultado.Text = " El resultado es " +suma;
    }
}