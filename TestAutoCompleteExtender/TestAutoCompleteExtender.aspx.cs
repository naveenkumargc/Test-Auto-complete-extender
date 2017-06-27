using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace TestAutoCompleteExtender
{
    public partial class TestAutoCompleteExtender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                aceForTxtBox.ContextKey = "Some Key which will be used by web service";
            }
        }

        protected void txt_testAutoComplete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}