﻿using menuavanzado.Registros.RegistroDVDs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace menuavanzado.Registros.RegistroDVDs
{
    public partial class RegistroDVD : Form
    {
        OpenFileDialog ubicacionimagen;
        OpenFileDialog ubicacionarchivo;

        public RegistroDVD()
        {
            InitializeComponent();
            textBoxcodigo.Text = generarcodigo();
        }

        private void buttonregistro_Click(object sender, EventArgs e)
        {
            ColeccionDVD x = new ColeccionDVD();
            bool confirmacion = false;

            if (textBoxAñoemision.Text != "")
            {
                if (textBoxCantidad.Text != "")
                {
                    if (textBoxcodigo.Text != "")
                    {
                        if (textBoxdescripcion.Text != "")
                        {
                            if (textBoxTitulo.Text != "")
                            {
                                if (textBoximagen.Text != "")
                                {

                                    confirmacion = true;

                                    DateTime fechaingreso = dateTimeFechaingreso.Value.Date.ToLocalTime();


                                    string Producto = textBoxTitulo.Text;
                                    string Tipo_DVD = comboBoxtipoDVD.Text;
                                    int Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                    string Codigo = textBoxcodigo.Text;
                                    int Año_emision = Convert.ToInt32(textBoxAñoemision.Text);
                                    bool Prestamo = (radioButtonNO.Checked == true) ? false : true;
                                    string Descripcion = textBoxdescripcion.Text;
                                    string imagen = obtenerimagen();

                                    if (Tipo_DVD == "Mp3")
                                    {
                                        string archivo = obtenerarchivo();
                                        DVD index1 = new DVD(Producto, Tipo_DVD, Codigo, Cantidad, Año_emision, fechaingreso, Prestamo, Descripcion, imagen, archivo);

                                        x.agregar(index1);

                                    }
                                    else
                                    {
                                        DVD index = new DVD(Producto, Tipo_DVD, Codigo, Cantidad, Año_emision, fechaingreso, Prestamo, Descripcion, imagen);

                                        x.agregar(index);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (confirmacion == false)
            {
                MessageBox.Show("Uno o mas de los campos del registro estan vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        //validaciones

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text.Length > 0)
            {
                string texto = textBoxTitulo.Text;
                textBoxTitulo.Text = texto.Substring(0, 1).ToUpper() + texto.Substring(1).ToLower();
                textBoxTitulo.SelectionStart = textBoxTitulo.Text.Length; // Colocamos el cursor al final del texto
                textBoxTitulo.SelectionLength = 0; 
            }
        }

        private void textBoxAñoemision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxDiaingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxmesingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxañoingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }


        private void buttonarchivo_Click_1(object sender, EventArgs e)
        {
            bool continuar = false;
            OpenFileDialog nuevo = new OpenFileDialog();

            do
            {

                try
                {

                    nuevo.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error al mostrar el diálogo de selección de archivo: " + ex.Message, "Error");

                }

                try
                {
                    Image comprobar = Image.FromFile(nuevo.FileName);

                    continuar = true;

                    textBoximagen.Text = Path.GetFileName(nuevo.FileName);
                    ubicacionimagen = nuevo;
                }
                catch (IOException ex)
                {


                    MessageBox.Show("Se ha producido un error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show("Se ha producido un error al seleccionar la imagen, seleccione una imagen valida porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            } while (continuar != true);

        }

        private void comboBoxtipoDVD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxtipoDVD.SelectedItem.ToString() == "Mp3")
            {
                labelArchivo.Visible = true;
                textBoxarchivo.Visible = true;
                buttonexaminararchivo.Visible = true;
            }
            else
            {


                labelArchivo.Visible = false;
                textBoxarchivo.Visible = false;
                buttonexaminararchivo.Visible = false;
            }


        }

        private void buttonexaminararchivo_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            OpenFileDialog nuevoarchivo = new OpenFileDialog();

            do
            {

                try
                {

                    nuevoarchivo.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error al mostrar el diálogo de selección de archivo: " + ex.Message+ ", intente de nuevo", "Error");

                }

                try
                {
                    string archivo = Path.GetFileName(nuevoarchivo.FileName);
                    FileInfo fileInfo = new FileInfo(archivo);
                    if (fileInfo.Extension.Equals(".mp3", StringComparison.OrdinalIgnoreCase)) 
                    {
                        continuar = true;

                        textBoxarchivo.Text = Path.GetFileName(nuevoarchivo.FileName);
                        ubicacionarchivo = nuevoarchivo;

                    }

                }
                catch (IOException ex)
                {


                    MessageBox.Show("Se ha producido un error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show("Se ha producido un error al seleccionar el Mp3, seleccione un Mp3 valido porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            } while (continuar != true);

        }

        //metodos

        public string obtenerimagen()
        {
            OpenFileDialog nuevo = ubicacionimagen;
            string caminocarpeta = "";
            string caminofinal = "";
            string caminoarchivo = nuevo.FileName;

            try
            {

                caminocarpeta = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                caminofinal = Path.Combine(caminocarpeta, "archivosmp3\\" + Path.GetFileName(nuevo.FileName));

                MessageBox.Show(caminofinal);

                File.Copy(caminoarchivo, caminofinal);



                return Path.GetFileName(nuevo.FileName); ;
            }

            catch (IOException e)
            {


                MessageBox.Show("Se ha producido un error\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException e)
            {

                MessageBox.Show("Se ha producido un error al seleccionar la imagen, seleccione una imagen valida porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return Path.GetFileName(nuevo.FileName);

        }

        public string obtenerarchivo()
        {
            OpenFileDialog nuevo = ubicacionarchivo;
            string caminocarpeta;
            string caminofinal;
            string caminoarchivo = nuevo.FileName;

            try
            {

                caminocarpeta = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                caminofinal = Path.Combine(caminocarpeta, "archivosmp3\\" + Path.GetFileName(nuevo.FileName));

                MessageBox.Show(caminofinal);

                File.Copy(caminoarchivo, caminofinal);



                return Path.GetFileName(nuevo.FileName); ;
            }

            catch (IOException e)
            {


                MessageBox.Show("Se ha producido un error\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException e)
            {

                MessageBox.Show("Se ha producido un error al seleccionar el archivo, seleccione un archivo caliso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return Path.GetFileName(nuevo.FileName);

        }

        string generarcodigo()
        {
            string resultado;
            bool continuar = false;
            ColeccionDVD revisar = new ColeccionDVD();

            do
            {
                Random codigo = new Random();
                resultado = Convert.ToString(codigo.Next(10000, 99999));
                continuar = revisar.confirmarcodigo(resultado);

            } while (continuar != true);

            return resultado;
        }

    }
}
