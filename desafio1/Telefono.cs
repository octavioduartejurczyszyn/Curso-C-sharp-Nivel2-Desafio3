using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        //private string modelo;
        //private string marca;
        //private string numeroTelefonico;
        private int codigoOperador;

        public string modelo { get; set; }
        public string marca { get; set; }


        //public string Modelo
        //{
        //    get { return modelo; }
        //    set { modelo = value; }
        //}
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador 
        {
            get { return codigoOperador; }
            set 
            {
                if (value == 1 || value == 2 || value == 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        // Cosntructor 
        public Telefono (string modelo, string marca )
        {
            this.modelo = modelo;
            this.marca = marca;
        }
      
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar (string contacto)
        {
            return "Llamando a " + contacto;
        }

        //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos
    }
}
