using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    public partial class ConstructorOverloading : System.Web.UI.Page
    {
        int x;
        public ConstructorOverloading() {
            x = 25;
        }
        public ConstructorOverloading(int y) {
            x = y;
        }
        public ConstructorOverloading(ConstructorOverloading w) {
            x = w.x;
        }
        public int show() {
            return (x);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ConstructorOverloading w1 = new ConstructorOverloading();
            Response.Write(w1.show() + "<br>");
            ConstructorOverloading w2 = new ConstructorOverloading(6);
            Response.Write(w2.show() + "<br>");
            ConstructorOverloading w3 = new ConstructorOverloading(w1);
            Response.Write(w3.show());
        }
    }
}