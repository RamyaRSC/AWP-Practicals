using System;

namespace Inheritance
{
    class SingleIn {
        public String show() {
            return ("Class A Method");
        }
    }
    class B : SingleIn {
        public String disp() {
            return ("Class B Method");
        }
    }

    public partial class SingleInheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            B obj = new B();
            Response.Write(obj.show());
            Response.Write("<br>" + obj.disp());
        }
    }
}