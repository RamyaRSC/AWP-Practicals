using System;
using System.Data;
using System.Xml;

namespace AJAX_and_XML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlTextReader rd = new XmlTextReader(Server.MapPath("~/XMLFile1.xml"));
            DataSet ds = new DataSet();
            ds.ReadXml(rd);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XmlTextWriter wr = new XmlTextWriter(Server.MapPath("~/f1.xml"), System.Text.Encoding.UTF8);
            wr.WriteStartDocument();
            wr.WriteStartElement("students");
            wr.WriteStartElement("student");
            wr.WriteElementString("name", TextBox1.Text);
            wr.WriteElementString("rollno", TextBox2.Text);
            wr.WriteElementString("class", TextBox3.Text);
            wr.WriteEndElement();
            wr.WriteEndElement();
            wr.WriteEndDocument();
            wr.Flush();
            Response.Redirect("~/f1.xml");
        }
    }
}