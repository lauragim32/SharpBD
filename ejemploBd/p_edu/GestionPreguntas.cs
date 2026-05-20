﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace p_edu
{
	public partial class GestionPreguntas : Form
	{
		// EXAMEN PASO 5.1: Esta cadena debe estar vacía. Cópiala de MainForm.cs
		private string cadenaConexion = "Server=localhost;Database=peducativa;Uid=root;Pwd=;"; 
		private int _idModulo;

		// EXAMEN PASO 5.2: El constructor debe recibir el ID y el Nombre del módulo
		public GestionPreguntas( int id, string nombre )
		{
			InitializeComponent();
			// El estudiante debe añadir los parámetros y asignar los valores aquí
			this._idModulo = id;
			//
			this.Text = "Preguntas de: " + nombre;
			//lamar a funcion 
			CargarPreguntas();
		}

		private void CargarPreguntas()
		{
			try {
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) {
					// EXAMEN PASO 6: Filtrar las preguntas por el ID del módulo recibido (_idModulo)
					string sql = "SELECT * FROM pregunta WHERE id_modulo = " + _idModulo;
					
					conexion.Open();
					MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion);
					DataTable dt = new DataTable();
					
					adp.Fill(dt);
					dgvPreguntas.DataSource = dt;
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
			{
			    // Aquí usamos el _idModulo que recibimos del formulario anterior
			    string sql = "INSERT INTO pregunta (descripcion, id_modulo) VALUES (@desc, @id)";
			    
			    using (MySqlConnection con = new MySqlConnection(cadenaConexion))
			    using (MySqlCommand cmd = new MySqlCommand(sql, con))
			    {
			        cmd.Parameters.AddWithValue("@desc", txtPregunta.Text); 
			        cmd.Parameters.AddWithValue("@id", _idModulo);
			        con.Open();
			        cmd.ExecuteNonQuery();
			    }
			    CargarPreguntas(); // Refresca la lista de preguntas
			}
		
	}
}
