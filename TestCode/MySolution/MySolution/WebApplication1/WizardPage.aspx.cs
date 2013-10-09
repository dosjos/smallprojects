using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class WizardPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Trace.Write("Hei!");
			Trace.Warn("Hallo!");
		}

		protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_name.Text) || _gender.SelectedItem == null)
			{
				e.Cancel = true;
				return;
			}

			_receiptLabel.Text = string.Format("Name: {0}<br>Address: {1}<br>Birthday: {2}<br>Gender: {3}<br>Email:{4}<br>{5}<br>",
				_name.Text,
				_address.Text,
				_birthday.SelectedDate,
				_gender.SelectedValue,
				_email.Text,
				_receiveUpdates.Checked ? "Spam me!" : "Don't spam me!"
				);
		}
	}
}