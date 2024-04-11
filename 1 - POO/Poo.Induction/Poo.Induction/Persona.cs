using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Induction
{
    public class Persona
    {
        //Variables publicas
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Variables privadas
        private string Title { get; set; }
        private string Dni { get; set; }

        //Sobrecarga de Constructores
        public Persona()
        {
            
        }

        public Persona(string name) 
        {
            this.Name = name;
        }

        public Persona(string name, string lastName, string dni, string title, int age)
        {
            this.Title = title;
            this.Age = age;
            //reutilizando metodos
            AssingData(name, lastName, dni);
        }

        //Sets
        public void SetDni(string dni)
        {
            this.Dni = dni;
        }

        public void SetTile(string title)
        {
            this.Title = $"Tecnico Programador en {title}";
        }

        //Gets
        public string GetTitle()
        {
            return this.Title;
        }

        public string GetDni()
        {
            return this.Dni;
        }

        //Sobre carga de Funciones/Metodos
        public void AssingData(string name)
        {
            this.Name = name;
        }

        public void AssingData(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public void AssingData(string name, string lastName, string dni)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Dni = dni;
        }

        public void AssingData(string name, string lastName, string dni, string title, int age)
        {
            this.Title = title;
            this.Age = age;
            //reutilizando metodos
            AssingData(name, lastName, dni);
        }

        //Metodo Especial
        public string ShowFullData()
        {
            return $"Mi nombre es {this.Name} {this.LastName}, con un titulo de {this.Title}, tengo {this.Age} y mi DNI es: {this.Dni}";
        }

        //Metodos privados
        private string CalculeDni()
        {
            Random random = new Random();

            // Generar un número aleatorio de 8 dígitos
            int randomNumber = random.Next(10000000, 99999999); // 8 dígitos

            // Convertir el número aleatorio en un string
            return randomNumber.ToString();
        }
    }
}
