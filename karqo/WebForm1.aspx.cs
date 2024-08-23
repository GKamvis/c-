using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace karqo
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountry.Items.Add("Türkiye");
                ddlCountry.Items.Add("ABŞ");
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);
            double result = 0;

            Dictionary<string, double> rates = new Dictionary<string, double>()
        {
            { "Türkiye", 6 },
            { "ABŞ", 10 }
        };

            if (rates.ContainsKey(ddlCountry.SelectedValue))
            {
                result = weight * rates[ddlCountry.SelectedValue];
            }

            lblTotal.Text = result.ToString();
        }


 
    }
}