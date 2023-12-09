using System;
using System.Web.UI.WebControls;

namespace calendar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Calendar1_DayRender(Object sender, DayRenderEventArgs e)
        {
            DateTime t1 = new DateTime(2023, 10, 31);
            DateTime t2 = t1.AddDays(7);
            Calendar1.SelectedDates.SelectRange(t1, t2);

            TimeSpan t = new DateTime(2023, 12, 25) - DateTime.Now;
            Label2.Text = "Days Remaining for Christmas" + t.Days.ToString();
        }
    }
}