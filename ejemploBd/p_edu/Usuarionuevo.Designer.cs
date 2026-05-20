
namespace p_edu 
{
	partial class UsuarioNuevo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label lblnombre;
		private System.Windows.Forms.Label lblclave;
		private System.Windows.Forms.Label lblrol;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.lblnombre = new System.Windows.Forms.Label();
			this.lblclave = new System.Windows.Forms.Label();
			this.lblrol = new System.Windows.Forms.Label();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(288, 75);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(288, 114);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(100, 20);
			this.txtClave.TabIndex = 1;
			// 
			// lblnombre
			// 
			this.lblnombre.Location = new System.Drawing.Point(182, 72);
			this.lblnombre.Name = "lblnombre";
			this.lblnombre.Size = new System.Drawing.Size(100, 23);
			this.lblnombre.TabIndex = 3;
			this.lblnombre.Text = "nombre";
			// 
			// lblclave
			// 
			this.lblclave.Location = new System.Drawing.Point(182, 114);
			this.lblclave.Name = "lblclave";
			this.lblclave.Size = new System.Drawing.Size(100, 23);
			this.lblclave.TabIndex = 4;
			this.lblclave.Text = "clave";
			// 
			// lblrol
			// 
			this.lblrol.Location = new System.Drawing.Point(182, 157);
			this.lblrol.Name = "lblrol";
			this.lblrol.Size = new System.Drawing.Size(100, 23);
			this.lblrol.TabIndex = 5;
			this.lblrol.Text = "rol";
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Location = new System.Drawing.Point(288, 154);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(121, 21);
			this.cmbRol.TabIndex = 6;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(153, 219);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(118, 45);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(303, 219);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(118, 45);
			this.BtnCancelar.TabIndex = 8;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			// 
			// UsuarioNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 276);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.lblrol);
			this.Controls.Add(this.lblclave);
			this.Controls.Add(this.lblnombre);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtNombre);
			this.Name = "UsuarioNuevo";
			this.Text = "UsuarioNuevo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
