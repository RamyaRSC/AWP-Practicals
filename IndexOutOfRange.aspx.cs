using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    public partial class IndexOutOfRange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50 }; // Sample array

            try
            {
                int index = Convert.ToInt32(TextBox1.Text); // Get index from TextBox
                int value = numbers[index]; // This line may throw IndexOutOfRangeException

                Label1.Text = $"Value at index {index}: {value}";
            }
            catch (IndexOutOfRangeException)
            {
                Label1.Text = "Index is out of range";
                // Handle the exception here or perform any necessary actions
            }
        }
    }
}