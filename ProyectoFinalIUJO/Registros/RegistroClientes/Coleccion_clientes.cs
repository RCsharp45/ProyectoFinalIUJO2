﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
	internal class Coleccion_clientes
	{
        public static List<Cliente> ListaClientes = new List<Cliente>();
		public void agregar(Cliente clien)
		{

            ListaClientes.Add(clien);

		}

        public void escribirenbase()
        {

            XmlDocument RegistroCLiente = new XmlDocument();

            RegistroCLiente.Load("Datos.xml");

            XmlNode Clientes = RegistroCLiente.SelectSingleNode("/registros/Personas");
        //    XmlNode MP3s = RegistroCLiente.SelectSingleNode("/registros/DVDs/MP3");
            
            Clientes.RemoveAll();



            foreach (Cliente cliente in RegistroCLiente)
            {

                XmlElement Persona = RegistroCLiente.CreateElement("Persona");

                XmlAttribute attribute = RegistroCLiente.CreateAttribute("nombre");

                attribute.Value = cliente.Nombre_Cliente;
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("apellido");
                attribute.Value = cliente.Apellido_Cliente;
                Persona.Attributes.Append(attribute);
                //Cedula ala base de datos
                attribute = RegistroCLiente.CreateAttribute("Cedula");
                attribute.Value = Convert.ToString(cliente.Cedula);
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("Sexo");
                attribute.Value = cliente.Sexo;
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("FechaNacimiento");
                DateTime fecha = cliente.FechaNacimientoCliente.Date;
                string stringfecha = fecha.ToString();
                attribute.Value = stringfecha;
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("TelefonoCelular");
                attribute.Value = Convert.ToString(cliente.TelefonoCelular);
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("TelefonoResidencial");
                attribute.Value = Convert.ToString(cliente.TelefonoResidencial);
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("CorreoElectronico");
                attribute.Value = cliente.CorreoElectronico;
                Persona.Attributes.Append(attribute);

                attribute = RegistroCLiente.CreateAttribute("Direccion");
                attribute.Value = cliente.Direccion;
                Persona.Attributes.Append(attribute);


                attribute = RegistroCLiente.CreateAttribute("FechaRegistroCliente");
                DateTime fecha1 = cliente.FechaRegistroCliente.Date;
                string stringfecha1 = fecha.ToString();
                attribute.Value = stringfecha;
                Persona.Attributes.Append(attribute);







                Persona.AppendChild(Persona);
               

     
                /*
                if (dvd.tipo_DVD == "Mp3")
                {
                    attribute = RegistroCLiente.CreateAttribute("Archivo");
                    attribute.Value = dvd.ubicacionArchivo;
                    producto.Attributes.Append(attribute);

                    MP3s.AppendChild(producto);

                }
                else if (dvd.tipo_DVD == "Videojuego")
                {

                    Juegos.AppendChild(producto);

                }
                else if (dvd.tipo_DVD == "Pelicula")
                {

                    peliculas.AppendChild(producto);

                }
                 */


            }

            RegistroCLiente.Save("Datos.xml");
        }
        // asdasfadsfasdfasdfasdfasdfiopashidofñhasdioñfasiodfhasiodpfhasuiopdfhioasdhifo
		/*public void Agregar(string nombre,string apellido,int cedula,bool sexo, DateTime fechaN, int telefonoC,int telefonoR,string correo,string direccion,DateTime fechaR)
		{
			Cliente x = new Cliente(nombre,apellido,cedula,sexo,fechaN,telefonoC,telefonoR,correo,direccion,fechaR);
			ListaClientes.Add(x);
		}*/
		public void Actualizar(int a, Cliente e)
		{
			foreach(Cliente s in ListaClientes)
			{
				if (s.Cedula == a)
				{
					s.Nombre_Cliente = e.Nombre_Cliente;
					s.Apellido_Cliente = e.Apellido_Cliente;
					s.Cedula = e.Cedula;
					s.Sexo = e.Sexo;
					s.FechaNacimientoCliente = e.FechaNacimientoCliente;
					s.TelefonoCelular = e.TelefonoCelular;
					s.TelefonoResidencial = e.TelefonoResidencial;
					s.CorreoElectronico = e.CorreoElectronico;
					s.Direccion = e.Direccion;
					s.FechaRegistroCliente = e.FechaRegistroCliente;
					break;
				}
			}
		}
	}
}
