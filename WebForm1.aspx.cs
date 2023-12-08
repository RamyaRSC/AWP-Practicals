using System;
using DLL;


namespace WADLL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            Class1 obj = new Class1();
            Label1.Text = ("Addition is " + obj.add(x, y).ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            Class1 obj = new Class1();
            Label1.Text = ("Subtraction is " + obj.sub(x, y).ToString());

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            Class1 obj = new Class1();
            Label1.Text = ("Multiplication is " + obj.mul(x, y).ToString());
        }
    }
}