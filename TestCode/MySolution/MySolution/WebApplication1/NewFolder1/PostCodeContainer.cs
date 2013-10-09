using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for PostCodeContainer
/// </summary>
public class PostCodeContainer : Control, INamingContainer
{
	private string _postCode;
	private string _postalName;

	public string PostCode
	{
		get { return _postCode; }
		set { _postCode = value; }
	}

	public string PostalName
	{
		get { return _postalName; }
		set { _postalName = value; }
	}

	public PostCodeContainer(string postCode, string postalName)
	{
		_postCode = postCode;
		_postalName = postalName;
	}
}