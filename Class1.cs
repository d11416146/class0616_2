using System;
using System.Security.Cryptography.X509Certificates;

public class Student
{
	public string[] Names;
	public Student(int size)
	{
		Names= new string[size];
		for(int i = 0; i < size; i++)
		{
			Names[i] = "AAA";
		}
	}
	public string this[int pos]
	{
		get
		{
			return this.Names[pos];
		}
		set
		{
			this.Names[pos] = value;
		}
	}
}
