using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class WebForm6 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int appTeller = (int)Application["teller"];
			_appLabel.Text = (++appTeller).ToString();
			Application["teller"] = appTeller;

			int sessionTeller = (int)Session["teller"];
			_sessionLabel.Text = (++sessionTeller).ToString();
			Session["teller"] = sessionTeller;

			

		}
	}
}