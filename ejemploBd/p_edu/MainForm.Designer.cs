/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 19/5/2026
 * Time: 8:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace p_edu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label lblEstado;
		
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
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(56, 29);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(636, 359);
			this.dgvUsuarios.TabIndex = 0;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(115, 409);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(256, 409);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 2;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(400, 409);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(545, 409);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// lblEstado
			// 
			this.lblEstado.Location = new System.Drawing.Point(324, 466);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(100, 23);
			this.lblEstado.TabIndex = 5;
			this.lblEstado.Text = "Listo";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 566);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvUsuarios);
			this.Name = "MainForm";
			this.Text = "p_edu";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
