/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 19/5/2026
 * Time: 9:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace p_edu
{
	partial class GestionModulos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvModulos;
		private System.Windows.Forms.Button BtnVerPreguntas;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.TextBox txtNombreEs;
		private System.Windows.Forms.TextBox txtNombreEn;
		
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
			this.dgvModulos = new System.Windows.Forms.DataGridView();
			this.BtnVerPreguntas = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.txtNombreEs = new System.Windows.Forms.TextBox();
			this.txtNombreEn = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvModulos
			// 
			this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModulos.Location = new System.Drawing.Point(82, 99);
			this.dgvModulos.Name = "dgvModulos";
			this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvModulos.Size = new System.Drawing.Size(571, 293);
			this.dgvModulos.TabIndex = 0;
			// 
			// BtnVerPreguntas
			// 
			this.BtnVerPreguntas.Location = new System.Drawing.Point(174, 451);
			this.BtnVerPreguntas.Name = "BtnVerPreguntas";
			this.BtnVerPreguntas.Size = new System.Drawing.Size(149, 55);
			this.BtnVerPreguntas.TabIndex = 1;
			this.BtnVerPreguntas.Text = "Ver Preguntas";
			this.BtnVerPreguntas.UseVisualStyleBackColor = true;
			this.BtnVerPreguntas.Click += new System.EventHandler(this.BtnVerPreguntasClick);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(410, 451);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(149, 55);
			this.BtnGuardar.TabIndex = 2;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNombreEs
			// 
			this.txtNombreEs.Location = new System.Drawing.Point(175, 23);
			this.txtNombreEs.Name = "txtNombreEs";
			this.txtNombreEs.Size = new System.Drawing.Size(384, 20);
			this.txtNombreEs.TabIndex = 3;
			// 
			// txtNombreEn
			// 
			this.txtNombreEn.Location = new System.Drawing.Point(175, 58);
			this.txtNombreEn.Name = "txtNombreEn";
			this.txtNombreEn.Size = new System.Drawing.Size(384, 20);
			this.txtNombreEn.TabIndex = 4;
			// 
			// GestionModulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 546);
			this.Controls.Add(this.txtNombreEn);
			this.Controls.Add(this.txtNombreEs);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.BtnVerPreguntas);
			this.Controls.Add(this.dgvModulos);
			this.Name = "GestionModulos";
			this.Text = "GestionModulos";
			((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
