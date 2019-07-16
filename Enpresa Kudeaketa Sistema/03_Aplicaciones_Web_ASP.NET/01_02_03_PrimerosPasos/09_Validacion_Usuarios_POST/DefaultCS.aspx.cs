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
        if (this.TextUsu.Text == "Loren" && this.TextPass.Text == "1234")
        {
            this.Server.Transfer("ValidoCS.aspx");
        }
        else
        {
            this.Server.Transfer("ErrorCS.aspx");
        }

        }

    }
