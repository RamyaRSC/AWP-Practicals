using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    interface I1 {
        String show();
    }
    interface I2 {
        String show();
    }
    class A : I1, I2 {
        String I1.show() {
            return ("I1.show");
        }
        String I2.show() {
            return ("I2.show");
        }
    }
    public partial class _interface : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            I1 obj = new A();
            Response.Write(obj.show());
            I2 obj2 = new A();
            Response.Write(obj2.show());
        }
    }
}