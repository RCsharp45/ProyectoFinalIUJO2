﻿/*
 * Creado por SharpDevelop.
 * Usuario: enyelberth
 * Fecha: 28/4/2023
 * Hora: 6:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace menuavanzado.Datos.Pantallas
{
	partial class PantallaCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputTelefonoCelular = new System.Windows.Forms.TextBox();
			this.inputCedula = new System.Windows.Forms.TextBox();
			this.inputApellido = new System.Windows.Forms.TextBox();
			this.InputNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.InputTelefonoResidencial = new System.Windows.Forms.TextBox();
			this.inputCorreo = new System.Windows.Forms.TextBox();
			this.InputDireccion = new System.Windows.Forms.TextBox();
			this.Btn_Registro = new System.Windows.Forms.Button();
			this.InputFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// InputTelefonoCelular
			// 
			this.InputTelefonoCelular.Location = new System.Drawing.Point(417, 268);
			this.InputTelefonoCelular.Name = "InputTelefonoCelular";
			this.InputTelefonoCelular.Size = new System.Drawing.Size(140, 20);
			this.InputTelefonoCelular.TabIndex = 19;
			this.InputTelefonoCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTelefonoCelularKeyPress);
			// 
			// inputCedula
			// 
			this.inputCedula.Location = new System.Drawing.Point(365, 169);
			this.inputCedula.Name = "inputCedula";
			this.inputCedula.Size = new System.Drawing.Size(192, 20);
			this.inputCedula.TabIndex = 18;
			this.inputCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputCedulaKeyPress);
			this.inputCedula.Validated += new System.EventHandler(this.InputCedulaValidated);
			// 
			// inputApellido
			// 
			this.inputApellido.Location = new System.Drawing.Point(365, 136);
			this.inputApellido.Name = "inputApellido";
			this.inputApellido.Size = new System.Drawing.Size(192, 20);
			this.inputApellido.TabIndex = 17;
			this.inputApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputApellidoKeyPress);
			// 
			// InputNombre
			// 
			this.InputNombre.Location = new System.Drawing.Point(365, 104);
			this.InputNombre.Name = "InputNombre";
			this.InputNombre.Size = new System.Drawing.Size(192, 20);
			this.InputNombre.TabIndex = 16;
			this.InputNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNombreKeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(235, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Nombre:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Snow;
			this.label6.Location = new System.Drawing.Point(249, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(346, 51);
			this.label6.TabIndex = 21;
			this.label6.Text = "Registrar Cliente";
			// 
			// InputTelefonoResidencial
			// 
			this.InputTelefonoResidencial.Location = new System.Drawing.Point(451, 299);
			this.InputTelefonoResidencial.Name = "InputTelefonoResidencial";
			this.InputTelefonoResidencial.Size = new System.Drawing.Size(106, 20);
			this.InputTelefonoResidencial.TabIndex = 26;

			this.InputTelefonoResidencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTelefonoResidencialKeyPress);
			// 
			// inputCorreo
			// 
			this.inputCorreo.Location = new System.Drawing.Point(365, 328);
			this.inputCorreo.Name = "inputCorreo";
			this.inputCorreo.Size = new System.Drawing.Size(194, 20);
			this.inputCorreo.TabIndex = 27;
			this.inputCorreo.TextChanged += new System.EventHandler(this.InputCorreoTextChanged);
			// 
			// InputDireccion
			// 
			this.InputDireccion.Location = new System.Drawing.Point(365, 362);
			this.InputDireccion.Name = "InputDireccion";
			this.InputDireccion.Size = new System.Drawing.Size(194, 20);
			this.InputDireccion.TabIndex = 28;
			// 
			// Btn_Registro
			// 
			this.Btn_Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Btn_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Registro.ForeColor = System.Drawing.Color.OldLace;
			this.Btn_Registro.Location = new System.Drawing.Point(286, 426);
			this.Btn_Registro.Name = "Btn_Registro";
			this.Btn_Registro.Size = new System.Drawing.Size(253, 35);
			this.Btn_Registro.TabIndex = 29;
			this.Btn_Registro.Text = "Registrar";
			this.Btn_Registro.UseVisualStyleBackColor = false;
			// 
			// InputFechaNacimiento
			// 
			this.InputFechaNacimiento.Location = new System.Drawing.Point(451, 232);
			this.InputFechaNacimiento.Name = "InputFechaNacimiento";
			this.InputFechaNacimiento.Size = new System.Drawing.Size(106, 20);
			this.InputFechaNacimiento.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label11.Location = new System.Drawing.Point(235, 133);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(110, 23);
			this.label11.TabIndex = 31;
			this.label11.Text = "Apellido:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label12.Location = new System.Drawing.Point(235, 164);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 23);
			this.label12.TabIndex = 32;
			this.label12.Text = "Cedula:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(235, 197);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 33;
			this.label1.Text = "Sexo:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(235, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 23);
			this.label3.TabIndex = 34;
			this.label3.Text = "Fecha de nacimiento:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(235, 265);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 23);
			this.label4.TabIndex = 35;
			this.label4.Text = "Telefono Celular:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(235, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(216, 23);
			this.label5.TabIndex = 36;
			this.label5.Text = "Telefono Residencial:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(235, 328);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 23);
			this.label7.TabIndex = 37;
			this.label7.Text = "Correo:";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label13.Location = new System.Drawing.Point(235, 362);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 23);
			this.label13.TabIndex = 38;
			this.label13.Text = "Direccion:";
			// 
			// radioButton1
			// 
			this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.radioButton1.Location = new System.Drawing.Point(417, 197);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(74, 24);
			this.radioButton1.TabIndex = 39;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Masculino";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.radioButton2.Location = new System.Drawing.Point(491, 197);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 40;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Femenino";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// PantallaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
			this.ClientSize = new System.Drawing.Size(839, 646);
			this.ControlBox = false;
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.InputFechaNacimiento);
			this.Controls.Add(this.Btn_Registro);
			this.Controls.Add(this.InputDireccion);
			this.Controls.Add(this.inputCorreo);
			this.Controls.Add(this.InputTelefonoResidencial);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.InputTelefonoCelular);
			this.Controls.Add(this.inputCedula);
			this.Controls.Add(this.inputApellido);
			this.Controls.Add(this.InputNombre);
			this.Controls.Add(this.label2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PantallaCliente";
			this.Text = "PantallaCliente";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker InputFechaNacimiento;
		private System.Windows.Forms.Button Btn_Registro;
		private System.Windows.Forms.TextBox InputDireccion;
		private System.Windows.Forms.TextBox inputCorreo;
		private System.Windows.Forms.TextBox InputTelefonoResidencial;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox InputNombre;
		private System.Windows.Forms.TextBox inputApellido;
		private System.Windows.Forms.TextBox inputCedula;
		private System.Windows.Forms.TextBox InputTelefonoCelular;
	}
}
