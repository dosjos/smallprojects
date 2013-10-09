using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PersonRepository
/// </summary>
public class PersonRepository
{
	private static readonly Dictionary<int, Person> _persons = new Dictionary<int, Person>();

	static PersonRepository()
	{
		_persons = new Dictionary<int, Person>();
		AddPerson(1, "Ole", "Pettersen");
		AddPerson(2, "Arne", "Nilsen");
		AddPerson(3, "Kjersti", "Moen");
		AddPerson(4, "Jens-Petter", "Dahl");
		AddPerson(5, "Rune", "Martinsen");
		AddPerson(6, "Nina", "Winge");
	}

	public static bool PersonExists(int id)
	{
		return _persons.ContainsKey(id);
	}

	public static void AddPerson(int id, string firstname, string lastname)
	{
		_persons.Add(id, new Person(firstname, lastname, id));
	}

	public static void UpdatePerson(int id, string firstname, string  lastname)
	{
		if (_persons.ContainsKey(id))
		{
			_persons[id].Firstname = firstname;
			_persons[id].Lastname = lastname;
		}
	}

	public static void RemovePerson(int id)
	{
		_persons.Remove(id);
	}


	public static Person GetPerson(int id)
	{
		return _persons[id];
	}

	public static List<Person> GetPersons()
	{
		var persons = new List<Person>(_persons.Values);
		return persons;
	}
}
