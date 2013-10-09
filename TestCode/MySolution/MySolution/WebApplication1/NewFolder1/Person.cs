using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
	public string Firstname { get; set; }
	public string Lastname { get; set; }
	public int Id { get; set; }
	public DateTime Created { get; private set; }

	public string FullName
	{
		get { return string.Format("{0} {1}", Firstname, Lastname); }
	}


	public Person()
	{
		Created = DateTime.Now;
	}

	public Person(string firstname, string lastname, int id)
		: this()
	{
		Firstname = firstname;
		Lastname = lastname;
		Id = id;
	}
}
