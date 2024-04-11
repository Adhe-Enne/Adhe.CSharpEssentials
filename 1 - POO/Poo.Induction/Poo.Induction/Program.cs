// See https://aka.ms/new-console-template for more information
using Poo.Induction;

/*
 Pequeño desafio: al declarar variables o metodos, hacerlo en ingles.
 */

Console.WriteLine("Hello, World!");

Persona persona = new Persona();
persona.Name = "Daniel";
persona.LastName = "Nina";
persona.Age = 28;
persona.SetTile("UTN");
persona.SetDni("394568741");

Console.WriteLine(persona.ShowFullData());

persona = new Persona();
persona.AssingData("Daniel", "Mamani", "12345678", "Programador C++", 18);
Console.WriteLine(persona.ShowFullData());

persona = new Persona("Lionel", "Messi", "123456415", "Ganar Mundiales vistes", 37);
Console.WriteLine(persona.ShowFullData());