using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    public partial class functionOverloading : System.Web.UI.Page
    {
        void area(int r)
        {
            Response.Write(3.14 * r * r);
        }
        void area(int l, int b)
        {
            Response.Write(l * b);
        }
        void area(double s)
        {
            Response.Write(s * s);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            area(a);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            area(l, b);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Double s = Convert.ToDouble(TextBox1.Text);
            area(s);
        }
    }
}