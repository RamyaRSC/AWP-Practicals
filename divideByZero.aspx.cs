using System;

namespace Inheritance
{
    public partial class divideByZero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            try {
                Response.Write(x / y);
            }
            catch (DivideByZeroException) {
                Response.Write("Can't Divide By zero");
            }
            finally {
                Response.Write(" ");
            }

        }
    }
}