// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;


Person person1 = new Person();
person1.FirstName = "YASİN";
person1.LastName = "KONUK";
person1.DateOfBirthYear = 2001;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


Console.ReadLine();
