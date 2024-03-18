using System;

class Book
{
	string title;
	string describe;
	string gender;

	Book() { }

	Book(string title, string describe, string gender)
	{
		this.title = title;
		this.describe = describe;
		this.gender = gender;
	}

	public void ToString() {
		
		Console.WriteLine("Titlo: " + this.title + ", Descricao: " + this.describe + ", Genero: " + this.gender);
	}

	static void Main(string[] args)
	{
		Book book = new Book();

		Book book2 = new Book("Tales of demons and gods",
								"A man that posses the special artefact returns to your infancy and now has the as goal to save the glory city",
								"Adventure");

		book.ToString();
		book2.ToString();
	}
}