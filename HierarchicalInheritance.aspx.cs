using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    class Hierarchical1
    {
        public int a = 6;
    }
    class Hierarchical2 : Hierarchical1
    {
        public int square()
        {
            return (a * a);
        }
    }
    class C : Hierarchical1
    {
        public int cube()
        {
            return (a * a * a);
        }
    }
    public partial class HierarchicalInheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hierarchical2 b = new Hierarchical2();
            C c = new C();
            Response.Write("Square=" + b.square());
            Response.Write("<br>" + "Cube=" + c.cube());

        }
    }
}