﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondtask
{
	
	struct Person{
		public string firstName;
 		public string lastName;
 		public int age; 
 		public Genders gender;
 		
		public enum Genders : int { Male, Female };
		
		
	public Person(string _firstName, string _lastName, int _age, Genders _gender) {
		firstName = _firstName;	
		lastName = _lastName; age = _age;
		gender= _gender;
		
		
	}
	public override string ToString() {
		{
		return firstName + " " + lastName + " (" + gender + "), age " + age;
		}

	}
	
	}

	class Program
	{
		public static void Main(string[] args)
		{
			Person p = new Person("Oleg", "Orlovsky", 18,Person.Genders.Male); Console.WriteLine(p);
			Console.ReadLine();
		
		}
	}
}