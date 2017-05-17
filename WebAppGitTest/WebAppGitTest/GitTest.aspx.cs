using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppGitTest
{
    public partial class GitTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cbTest.Checked = false;
                cbTest.Text = "Unchecked";
                //teste para commit
            }

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            if (cbTest.Text == "Checked")
            {
                cbTest.Text = "Unchecked";
                cbTest.Checked = false;
            }
            else
            {
                cbTest.Text = "Checked";
                cbTest.Checked = true;
             }
        }
    }
}