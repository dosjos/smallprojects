using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WizardControll
{
    public partial class WizardPage : System.Web.UI.Page
    {
        String Navn, Adresse, Gender,Email;
        DateTime BirtDate;
        bool brev;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Navn = TextBox1.Text;
            Adresse = TextBox2.Text;
            BirtDate = Calendar1.SelectedDate;
            Gender = RadioButton1.Checked ? "Mann" : "Kvinne";
            Email = TextBox3.Text;
            brev = CheckBox1.Checked;
            String nyhet = brev ? "" : "ikke";
            Label7.Text = String.Format("Hei {0} du bor her: {1} <br /> Du er født {2} og epost adressen din er {3}. Du vil {4} ha nyhetsbrev"
            , Navn, Adresse, BirtDate, Email, nyhet);
        }
    }
}