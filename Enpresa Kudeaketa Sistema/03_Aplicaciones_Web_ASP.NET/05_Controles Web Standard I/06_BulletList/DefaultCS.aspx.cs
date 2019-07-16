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
        this.Lista.BulletStyle = BulletStyle.Numbered;
        this.Lista.DisplayMode = BulletedListDisplayMode.Text;
    }
    protected void Lista_Click(object sender, BulletedListEventArgs e)
    {
        //'Es para el caso de que seleccionemos el modo BOTON.
        this.etiqueta.Text = e.Index + 1 + " - " + this.Lista.Items[e.Index].Text;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (this.DropDownList1.SelectedValue)
        {
            case "NotSet":
                this.Lista.BulletStyle = BulletStyle.NotSet;
                break;
            case "Numbered":
                this.Lista.BulletStyle = BulletStyle.Numbered;
                break;
            case "LowerAlpha":
                this.Lista.BulletStyle = BulletStyle.LowerAlpha;
                break;
            case "UpperAlpha":
                this.Lista.BulletStyle = BulletStyle.UpperAlpha;
                break;
            case "LowerRoman":
                this.Lista.BulletStyle = BulletStyle.LowerRoman;
                break;
            case "UpperRoman":
                this.Lista.BulletStyle = BulletStyle.UpperRoman;
                break;
            case "Disc":
                this.Lista.BulletStyle = BulletStyle.Disc;
                break;
            case "Circle":
                this.Lista.BulletStyle = BulletStyle.Circle;
                break;
            case "Square":
                this.Lista.BulletStyle = BulletStyle.Square;
                break;
            case "Image":
                this.Lista.BulletImageUrl = "4.gif";
                this.Lista.BulletStyle = BulletStyle.CustomImage;
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }



    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        switch (this.DropDownList2.SelectedValue)
        {
            case "texto":
                this.Lista.DisplayMode = BulletedListDisplayMode.Text;
                break;
            case "LinkButton":
                this.Lista.DisplayMode = BulletedListDisplayMode.LinkButton;
                break;
            case "HyperLink":
                this.Lista.DisplayMode = BulletedListDisplayMode.HyperLink;
                break;

        }


    }
}